namespace AydarOOP4
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.paint_box = new System.Windows.Forms.Panel();
            this.label_paintbox = new System.Windows.Forms.Label();
            this.label_x = new System.Windows.Forms.Label();
            this.label_y = new System.Windows.Forms.Label();
            this.button_clear_paintbox = new System.Windows.Forms.Button();
            this.button_show = new System.Windows.Forms.Button();
            this.button_deletestorage = new System.Windows.Forms.Button();
            this.button_del_item_storage = new System.Windows.Forms.Button();
            this.paint_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // paint_box
            // 
            this.paint_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paint_box.BackColor = System.Drawing.SystemColors.Info;
            this.paint_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paint_box.Controls.Add(this.label_paintbox);
            this.paint_box.Location = new System.Drawing.Point(9, 10);
            this.paint_box.Margin = new System.Windows.Forms.Padding(2);
            this.paint_box.Name = "paint_box";
            this.paint_box.Size = new System.Drawing.Size(454, 388);
            this.paint_box.TabIndex = 0;
            this.paint_box.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paint_box_MouseClick);
            this.paint_box.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paint_box_MouseMove);
            // 
            // label_paintbox
            // 
            this.label_paintbox.AutoSize = true;
            this.label_paintbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_paintbox.Location = new System.Drawing.Point(3, 3);
            this.label_paintbox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_paintbox.Name = "label_paintbox";
            this.label_paintbox.Size = new System.Drawing.Size(157, 21);
            this.label_paintbox.TabIndex = 0;
            this.label_paintbox.Text = "Окно для рисования";
            // 
            // label_x
            // 
            this.label_x.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_x.AutoSize = true;
            this.label_x.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_x.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_x.Location = new System.Drawing.Point(467, 10);
            this.label_x.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_x.Name = "label_x";
            this.label_x.Size = new System.Drawing.Size(119, 21);
            this.label_x.TabIndex = 1;
            this.label_x.Text = "Координаты X: ";
            // 
            // label_y
            // 
            this.label_y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_y.AutoSize = true;
            this.label_y.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label_y.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_y.Location = new System.Drawing.Point(467, 32);
            this.label_y.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_y.Name = "label_y";
            this.label_y.Size = new System.Drawing.Size(119, 21);
            this.label_y.TabIndex = 2;
            this.label_y.Text = "Координаты Y: ";
            // 
            // button_clear_paintbox
            // 
            this.button_clear_paintbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_clear_paintbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear_paintbox.Location = new System.Drawing.Point(471, 352);
            this.button_clear_paintbox.Margin = new System.Windows.Forms.Padding(2);
            this.button_clear_paintbox.Name = "button_clear_paintbox";
            this.button_clear_paintbox.Size = new System.Drawing.Size(134, 46);
            this.button_clear_paintbox.TabIndex = 3;
            this.button_clear_paintbox.Text = "Очистить панель";
            this.button_clear_paintbox.UseVisualStyleBackColor = true;
            this.button_clear_paintbox.Click += new System.EventHandler(this.button_clear_paintbox_Click);
            // 
            // button_show
            // 
            this.button_show.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_show.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_show.Location = new System.Drawing.Point(471, 58);
            this.button_show.Margin = new System.Windows.Forms.Padding(2);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(134, 79);
            this.button_show.TabIndex = 4;
            this.button_show.Text = "Отобразить объекты из хранилища";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // button_deletestorage
            // 
            this.button_deletestorage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_deletestorage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_deletestorage.Location = new System.Drawing.Point(471, 268);
            this.button_deletestorage.Margin = new System.Windows.Forms.Padding(2);
            this.button_deletestorage.Name = "button_deletestorage";
            this.button_deletestorage.Size = new System.Drawing.Size(134, 79);
            this.button_deletestorage.TabIndex = 5;
            this.button_deletestorage.Text = "Удалить все элементы из хранилища";
            this.button_deletestorage.UseVisualStyleBackColor = true;
            this.button_deletestorage.Click += new System.EventHandler(this.button_deletestorage_Click);
            // 
            // button_del_item_storage
            // 
            this.button_del_item_storage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_del_item_storage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_del_item_storage.Location = new System.Drawing.Point(471, 141);
            this.button_del_item_storage.Margin = new System.Windows.Forms.Padding(2);
            this.button_del_item_storage.Name = "button_del_item_storage";
            this.button_del_item_storage.Size = new System.Drawing.Size(134, 122);
            this.button_del_item_storage.TabIndex = 6;
            this.button_del_item_storage.Text = "Удалить выделенные элементы из хранилища и панели";
            this.button_del_item_storage.UseVisualStyleBackColor = true;
            this.button_del_item_storage.Click += new System.EventHandler(this.button_del_item_storage_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 407);
            this.Controls.Add(this.button_del_item_storage);
            this.Controls.Add(this.button_clear_paintbox);
            this.Controls.Add(this.button_deletestorage);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.label_y);
            this.Controls.Add(this.label_x);
            this.Controls.Add(this.paint_box);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "AydarOOP4";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.paint_box.ResumeLayout(false);
            this.paint_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paint_box;
        private System.Windows.Forms.Label label_paintbox;
        private System.Windows.Forms.Label label_x;
        private System.Windows.Forms.Label label_y;
        private System.Windows.Forms.Button button_clear_paintbox;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Button button_deletestorage;
        private System.Windows.Forms.Button button_del_item_storage;
    }
}

