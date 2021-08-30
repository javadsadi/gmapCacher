using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using System.Globalization;
using System.IO;

namespace gmapCacher
{
    public partial class Form1 : Form
    {
        internal readonly GMapOverlay objects = new GMapOverlay("objects");
        List<GMapProvider> MapProviders_List;
        public Form1()
        {
            InitializeComponent();
            gmap.Overlays.Add(objects);
            gmap.Manager.OnTileCacheComplete += new TileCacheComplete(OnTileCacheComplete);
            gmap.Manager.OnTileCacheStart += new TileCacheStart(OnTileCacheStart);
            gmap.Manager.OnTileCacheProgress += new TileCacheProgress(OnTileCacheProgress);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\settingPrefetch.info";

            if (!File.Exists(path))
            {
                // Create a file to write to.
                string[] defaultSettings = { "7", "2", "26", "0" };
                File.WriteAllLines(path, defaultSettings);
            }

            string[] settings = File.ReadAllLines(path);

            MapProviders_List = GMapProviders.List;
            Map_provider_combox.Items.Add(MapProviders_List[0].Name);
            Map_provider_combox.Items.Add(MapProviders_List[1].Name);
            Map_provider_combox.Items.Add(MapProviders_List[3].Name);
            Map_provider_combox.Items.Add(MapProviders_List[12].Name);
            Map_provider_combox.Items.Add(MapProviders_List[13].Name);
            Map_provider_combox.Items.Add(MapProviders_List[18].Name);
            Map_provider_combox.Items.Add(MapProviders_List[19].Name);
            Map_provider_combox.Items.Add(MapProviders_List[20].Name);
            Map_provider_combox.Items.Add(MapProviders_List[21].Name);
            Map_provider_combox.SelectedIndex = Convert.ToInt32(settings[0]);
            //gmap.MapProvider = GoogleHybridMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gmap.Position = new PointLatLng(Convert.ToDouble(settings[2]), Convert.ToDouble(settings[3]));
            gmap.MinZoom = 1;
            gmap.MaxZoom = 20;
            gmap.Zoom = Convert.ToInt32(settings[1]);
            Zoom_size_lbl.Text = "Zoom: " + Convert.ToString(gmap.Zoom);
        }

        private void prefetchBtn_Click(object sender, EventArgs e)
        {
            RectLatLng area = gmap.SelectedArea;
            if (area.IsEmpty)
            {
                DialogResult res = MessageBox.Show("No fetch area defined, fetch displayed on screen?", "Rip", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    area = gmap.ViewArea;
                }
            }

            if (!area.IsEmpty)
            {
                DialogResult res = MessageBox.Show("Ready fetch from Zoom " + Convert.ToString(minZoomNum.Value) + " to " + Convert.ToString(maxZoomNum.Value)+" ? ", "Prefetch tiles", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    for (int i = (int)minZoomNum.Value; i <= (int)maxZoomNum.Value; i++)
                    { 
                    
                        using (TilePrefetcher obj = new TilePrefetcher())
                        {
                            obj.Overlay = objects; // set overlay if you want to see cache progress on the map
                            obj.Shuffle = gmap.Manager.Mode != AccessMode.CacheOnly;

                            obj.Owner = this;
                            obj.ShowCompleteMessage = false;
                            obj.Start(area, i, gmap.MapProvider, gmap.Manager.Mode == AccessMode.CacheOnly ? 0 : 100, gmap.Manager.Mode == AccessMode.CacheOnly ? 0 : 1);
                        }

                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Select map area holding ALT key", "GMap.NET", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            gmap.ShowExportDialog();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure?", "Clear GMap.NET cache?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                try
                {
                    gmap.Manager.PrimaryCache.DeleteOlderThan(DateTime.Now, null);
                    MessageBox.Show("Done. Cache is clear.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            gmap.ShowImportDialog();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", gmap.CacheLocation);
        }

        private void gmap_OnTileLoadComplete(long ElapsedMilliseconds)
        {
            //gmap.ElapsedMilliseconds = ElapsedMilliseconds;

            MethodInvoker m = delegate ()
            {
                //panelMenu.Text = "Menu, last load in " + MainMap.ElapsedMilliseconds + "ms";

                textBoxMemory.Text = string.Format(CultureInfo.InvariantCulture, "{0:0.00} MB of {1:0.00} MB", gmap.Manager.MemoryCache.Size, gmap.Manager.MemoryCache.Capacity);
            };
            try
            {
                BeginInvoke(m);
            }
            catch
            {
            }
        }

        private void gmap_OnMapZoomChanged()
        {
            Zoom_size_lbl.Text = "Zoom: " + Convert.ToString(gmap.Zoom);
            minZoomNum.Value = (decimal)gmap.Zoom;
        }

        private void Map_provider_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GMapProvider p in MapProviders_List)
            {
                if (p.Name == Map_provider_combox.GetItemText(Map_provider_combox.SelectedItem))
                {
                    gmap.MapProvider = p;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            string path = Application.StartupPath + "\\settingPrefetch.info";

            string[] Settings = new string[4];
            Settings[0] = Convert.ToString(Map_provider_combox.SelectedIndex);
            Settings[1] = Convert.ToString(gmap.Zoom);
            Settings[2] = Convert.ToString(gmap.Position.Lat);
            Settings[3] = Convert.ToString(gmap.Position.Lng);
            File.WriteAllLines(path, Settings);

            e.Cancel = false;

        }

        void OnTileCacheComplete()
        {
            long size = 0;
            int db = 0;
            try
            {
                DirectoryInfo di = new DirectoryInfo(gmap.CacheLocation);
                var dbs = di.GetFiles("*.gmdb", SearchOption.AllDirectories);
                foreach (var d in dbs)
                {
                    size += d.Length;
                    db++;
                }
            }
            catch
            {
            }

            if (!IsDisposed)
            {
                MethodInvoker m = delegate
                {
                    textBoxCacheSize.Text = string.Format(CultureInfo.InvariantCulture, "{0} db in {1:00} MB", db, size / (1024.0 * 1024.0));
                    textBoxCacheStatus.Text = "all tiles saved!";
                };

                if (!IsDisposed)
                {
                    try
                    {
                        Invoke(m);
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }

        void OnTileCacheStart()
        {
            
            if (!IsDisposed)
            {
                MethodInvoker m = delegate
                {
                    textBoxCacheStatus.Text = "saving tiles...";
                };
                Invoke(m);
            }
        }

        void OnTileCacheProgress(int left)
        {
            if (!IsDisposed)
            {
                MethodInvoker m = delegate
                {
                    textBoxCacheStatus.Text = left + " tile to save...";
                };
                Invoke(m);
            }
        }

        private void clearMapBtn_Click(object sender, EventArgs e)
        {
            objects.Clear();
        }

        private void gmap_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.None)
            {
                PointLatLng mouse_pointer_position = gmap.FromLocalToLatLng(e.X, e.Y);
                Mouse_position_lbl.Text = string.Format("Lat= {0:0.######}  Long= {1:0.######}", mouse_pointer_position.Lat, mouse_pointer_position.Lng);
            }
        }
    }
}
