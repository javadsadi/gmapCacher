namespace gmapCacher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.importBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.prefetchBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.textBoxMemory = new System.Windows.Forms.TextBox();
            this.Zoom_size_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Map_provider_combox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCacheSize = new System.Windows.Forms.TextBox();
            this.textBoxCacheStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.minZoomNum = new System.Windows.Forms.NumericUpDown();
            this.maxZoomNum = new System.Windows.Forms.NumericUpDown();
            this.clearMapBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.minZoomNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxZoomNum)).BeginInit();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(253, 12);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 2;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(757, 684);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 0D;
            this.gmap.OnTileLoadComplete += new GMap.NET.TileLoadComplete(this.gmap_OnTileLoadComplete);
            this.gmap.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.gmap_OnMapZoomChanged);
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(12, 252);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(220, 37);
            this.importBtn.TabIndex = 1;
            this.importBtn.Text = "Import";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(12, 209);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(220, 37);
            this.exportBtn.TabIndex = 2;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // prefetchBtn
            // 
            this.prefetchBtn.Location = new System.Drawing.Point(12, 80);
            this.prefetchBtn.Name = "prefetchBtn";
            this.prefetchBtn.Size = new System.Drawing.Size(220, 37);
            this.prefetchBtn.TabIndex = 3;
            this.prefetchBtn.Text = "Prefetch selected area";
            this.prefetchBtn.UseVisualStyleBackColor = true;
            this.prefetchBtn.Click += new System.EventHandler(this.prefetchBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(12, 123);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(220, 37);
            this.openBtn.TabIndex = 4;
            this.openBtn.Text = "Open cache folder";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(12, 166);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(220, 37);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "Clear tiles cache";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // textBoxMemory
            // 
            this.textBoxMemory.Location = new System.Drawing.Point(12, 327);
            this.textBoxMemory.Name = "textBoxMemory";
            this.textBoxMemory.ReadOnly = true;
            this.textBoxMemory.Size = new System.Drawing.Size(220, 20);
            this.textBoxMemory.TabIndex = 6;
            this.textBoxMemory.Text = "...";
            // 
            // Zoom_size_lbl
            // 
            this.Zoom_size_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Zoom_size_lbl.AutoSize = true;
            this.Zoom_size_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Zoom_size_lbl.Location = new System.Drawing.Point(950, 20);
            this.Zoom_size_lbl.Name = "Zoom_size_lbl";
            this.Zoom_size_lbl.Size = new System.Drawing.Size(42, 13);
            this.Zoom_size_lbl.TabIndex = 129;
            this.Zoom_size_lbl.Text = "Zoom:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 131;
            this.label1.Text = "Map provider:";
            // 
            // Map_provider_combox
            // 
            this.Map_provider_combox.FormattingEnabled = true;
            this.Map_provider_combox.Location = new System.Drawing.Point(90, 20);
            this.Map_provider_combox.Name = "Map_provider_combox";
            this.Map_provider_combox.Size = new System.Drawing.Size(157, 21);
            this.Map_provider_combox.TabIndex = 130;
            this.Map_provider_combox.SelectedIndexChanged += new System.EventHandler(this.Map_provider_combox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 132;
            this.label2.Text = "Memory cache usage :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 134;
            this.label3.Text = "Disk cache status :";
            // 
            // textBoxCacheSize
            // 
            this.textBoxCacheSize.Location = new System.Drawing.Point(12, 370);
            this.textBoxCacheSize.Name = "textBoxCacheSize";
            this.textBoxCacheSize.ReadOnly = true;
            this.textBoxCacheSize.Size = new System.Drawing.Size(220, 20);
            this.textBoxCacheSize.TabIndex = 133;
            this.textBoxCacheSize.Text = "...";
            // 
            // textBoxCacheStatus
            // 
            this.textBoxCacheStatus.AutoSize = true;
            this.textBoxCacheStatus.Location = new System.Drawing.Point(12, 403);
            this.textBoxCacheStatus.Name = "textBoxCacheStatus";
            this.textBoxCacheStatus.Size = new System.Drawing.Size(16, 13);
            this.textBoxCacheStatus.TabIndex = 136;
            this.textBoxCacheStatus.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 138;
            this.label4.Text = "Zoom level :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 139;
            this.label5.Text = "to";
            // 
            // minZoomNum
            // 
            this.minZoomNum.Location = new System.Drawing.Point(83, 54);
            this.minZoomNum.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.minZoomNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minZoomNum.Name = "minZoomNum";
            this.minZoomNum.Size = new System.Drawing.Size(44, 20);
            this.minZoomNum.TabIndex = 140;
            this.minZoomNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // maxZoomNum
            // 
            this.maxZoomNum.Location = new System.Drawing.Point(155, 54);
            this.maxZoomNum.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.maxZoomNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxZoomNum.Name = "maxZoomNum";
            this.maxZoomNum.Size = new System.Drawing.Size(44, 20);
            this.maxZoomNum.TabIndex = 141;
            this.maxZoomNum.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // clearMapBtn
            // 
            this.clearMapBtn.Location = new System.Drawing.Point(12, 434);
            this.clearMapBtn.Name = "clearMapBtn";
            this.clearMapBtn.Size = new System.Drawing.Size(65, 37);
            this.clearMapBtn.TabIndex = 142;
            this.clearMapBtn.Text = "Clear map";
            this.clearMapBtn.UseVisualStyleBackColor = true;
            this.clearMapBtn.Click += new System.EventHandler(this.clearMapBtn_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1022, 708);
            this.Controls.Add(this.clearMapBtn);
            this.Controls.Add(this.maxZoomNum);
            this.Controls.Add(this.minZoomNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCacheStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCacheSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Map_provider_combox);
            this.Controls.Add(this.Zoom_size_lbl);
            this.Controls.Add(this.textBoxMemory);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.prefetchBtn);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.gmap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Prefetch tiles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.minZoomNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxZoomNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Button prefetchBtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox textBoxMemory;
        private System.Windows.Forms.Label Zoom_size_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Map_provider_combox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCacheSize;
        private System.Windows.Forms.Label textBoxCacheStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown minZoomNum;
        private System.Windows.Forms.NumericUpDown maxZoomNum;
        private System.Windows.Forms.Button clearMapBtn;
    }
}

