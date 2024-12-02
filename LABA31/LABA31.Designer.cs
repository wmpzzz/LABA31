namespace LABA31
{
    partial class LABA31
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LABA31));
            FileMenuStrip = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            CreateToolStripMenuItem = new ToolStripMenuItem();
            OpenToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            CloseToolStripMenuItem = new ToolStripMenuItem();
            FormatToolStripMenuItem = new ToolStripMenuItem();
            ColorToolStripMenuItem = new ToolStripMenuItem();
            FontToolStripMenuItem = new ToolStripMenuItem();
            FileTextRichTextBox = new RichTextBox();
            SaveFileDialog = new SaveFileDialog();
            OpenFileDialog = new OpenFileDialog();
            ToolStrip = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            LeftToolStripMenuItem = new ToolStripMenuItem();
            CenterToolStripMenuItem = new ToolStripMenuItem();
            RightToolStripMenuItem = new ToolStripMenuItem();
            toolStripContainer1 = new ToolStripContainer();
            statusStrip1 = new StatusStrip();
            DatesToolStripStatusLabel = new ToolStripStatusLabel();
            DateToolStripStatusLabel = new ToolStripStatusLabel();
            TimeToolStripStatusLabel = new ToolStripStatusLabel();
            NumbersToolStripStatusLabel = new ToolStripStatusLabel();
            timer = new System.Windows.Forms.Timer(components);
            FileMenuStrip.SuspendLayout();
            ToolStrip.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // FileMenuStrip
            // 
            FileMenuStrip.BackColor = Color.White;
            FileMenuStrip.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem, FormatToolStripMenuItem });
            FileMenuStrip.Location = new Point(0, 0);
            FileMenuStrip.Name = "FileMenuStrip";
            FileMenuStrip.Size = new Size(800, 24);
            FileMenuStrip.TabIndex = 0;
            FileMenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CreateToolStripMenuItem, OpenToolStripMenuItem, SaveToolStripMenuItem, toolStripSeparator1, CloseToolStripMenuItem });
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            FileToolStripMenuItem.Size = new Size(48, 20);
            FileToolStripMenuItem.Text = "Файл";
            FileToolStripMenuItem.Click += CreateToolStripMenuItem_Click;
            // 
            // CreateToolStripMenuItem
            // 
            CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            CreateToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            CreateToolStripMenuItem.Size = new Size(180, 22);
            CreateToolStripMenuItem.Text = "Создать";
            CreateToolStripMenuItem.Click += CreateToolStripMenuItem_Click;
            // 
            // OpenToolStripMenuItem
            // 
            OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            OpenToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            OpenToolStripMenuItem.Size = new Size(180, 22);
            OpenToolStripMenuItem.Text = "Открыть";
            OpenToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            SaveToolStripMenuItem.Size = new Size(180, 22);
            SaveToolStripMenuItem.Text = "Сохранить";
            SaveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // CloseToolStripMenuItem
            // 
            CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            CloseToolStripMenuItem.Size = new Size(180, 22);
            CloseToolStripMenuItem.Text = "Закрыть";
            CloseToolStripMenuItem.Click += CloseToolStripMenuItem_Click;
            // 
            // FormatToolStripMenuItem
            // 
            FormatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ColorToolStripMenuItem, FontToolStripMenuItem });
            FormatToolStripMenuItem.Name = "FormatToolStripMenuItem";
            FormatToolStripMenuItem.Size = new Size(115, 20);
            FormatToolStripMenuItem.Text = "Форматирование";
            // 
            // ColorToolStripMenuItem
            // 
            ColorToolStripMenuItem.Name = "ColorToolStripMenuItem";
            ColorToolStripMenuItem.Size = new Size(113, 22);
            ColorToolStripMenuItem.Text = "Цвет";
            ColorToolStripMenuItem.Click += ColorToolStripMenuItem_Click;
            // 
            // FontToolStripMenuItem
            // 
            FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            FontToolStripMenuItem.Size = new Size(113, 22);
            FontToolStripMenuItem.Text = "Шрифт";
            FontToolStripMenuItem.Click += FontToolStripMenuItem_Click;
            // 
            // FileTextRichTextBox
            // 
            FileTextRichTextBox.Location = new Point(0, 46);
            FileTextRichTextBox.Name = "FileTextRichTextBox";
            FileTextRichTextBox.Size = new Size(800, 392);
            FileTextRichTextBox.TabIndex = 1;
            FileTextRichTextBox.Text = "";
            FileTextRichTextBox.TextChanged += FileTextRichTextBox_TextChanged;
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.FileName = "openFileDialog1";
            // 
            // ToolStrip
            // 
            ToolStrip.Dock = DockStyle.None;
            ToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            ToolStrip.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            ToolStrip.Location = new Point(0, 24);
            ToolStrip.Name = "ToolStrip";
            ToolStrip.RenderMode = ToolStripRenderMode.System;
            ToolStrip.Size = new Size(104, 25);
            ToolStrip.TabIndex = 2;
            ToolStrip.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { LeftToolStripMenuItem, CenterToolStripMenuItem, RightToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(101, 22);
            toolStripDropDownButton1.Text = "Выравнивание";
            // 
            // LeftToolStripMenuItem
            // 
            LeftToolStripMenuItem.Name = "LeftToolStripMenuItem";
            LeftToolStripMenuItem.Size = new Size(180, 22);
            LeftToolStripMenuItem.Text = "По левому краю";
            LeftToolStripMenuItem.Click += LeftToolStripMenuItem_Click;
            // 
            // CenterToolStripMenuItem
            // 
            CenterToolStripMenuItem.Name = "CenterToolStripMenuItem";
            CenterToolStripMenuItem.Size = new Size(180, 22);
            CenterToolStripMenuItem.Text = "По центру";
            CenterToolStripMenuItem.Click += CenterToolStripMenuItem_Click;
            // 
            // RightToolStripMenuItem
            // 
            RightToolStripMenuItem.Name = "RightToolStripMenuItem";
            RightToolStripMenuItem.Size = new Size(180, 22);
            RightToolStripMenuItem.Text = "По правому краю";
            RightToolStripMenuItem.Click += RightToolStripMenuItem_Click;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.BackColor = Color.White;
            toolStripContainer1.ContentPanel.Controls.Add(statusStrip1);
            toolStripContainer1.ContentPanel.Controls.Add(FileTextRichTextBox);
            toolStripContainer1.ContentPanel.Controls.Add(ToolStrip);
            toolStripContainer1.ContentPanel.Size = new Size(800, 450);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.LeftToolStripPanelVisible = false;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.RightToolStripPanelVisible = false;
            toolStripContainer1.Size = new Size(800, 450);
            toolStripContainer1.TabIndex = 3;
            toolStripContainer1.Text = "toolStripContainer1";
            toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { DatesToolStripStatusLabel, DateToolStripStatusLabel, TimeToolStripStatusLabel, NumbersToolStripStatusLabel });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // DatesToolStripStatusLabel
            // 
            DatesToolStripStatusLabel.Name = "DatesToolStripStatusLabel";
            DatesToolStripStatusLabel.Size = new Size(35, 17);
            DatesToolStripStatusLabel.Text = "Дата:";
            // 
            // DateToolStripStatusLabel
            // 
            DateToolStripStatusLabel.Name = "DateToolStripStatusLabel";
            DateToolStripStatusLabel.Size = new Size(30, 17);
            DateToolStripStatusLabel.Text = "дата";
            // 
            // TimeToolStripStatusLabel
            // 
            TimeToolStripStatusLabel.Name = "TimeToolStripStatusLabel";
            TimeToolStripStatusLabel.Size = new Size(41, 17);
            TimeToolStripStatusLabel.Text = "время";
            // 
            // NumbersToolStripStatusLabel
            // 
            NumbersToolStripStatusLabel.Name = "NumbersToolStripStatusLabel";
            NumbersToolStripStatusLabel.Size = new Size(101, 17);
            NumbersToolStripStatusLabel.Text = "кол во символов";
            // 
            // timer
            // 
            timer.Tick += Timer_Tick;
            // 
            // LABA31
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FileMenuStrip);
            Controls.Add(toolStripContainer1);
            MainMenuStrip = FileMenuStrip;
            Name = "LABA31";
            Text = "Лабораторная работа 31";
            Load += LABA31_Load;
            FileMenuStrip.ResumeLayout(false);
            FileMenuStrip.PerformLayout();
            ToolStrip.ResumeLayout(false);
            ToolStrip.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ContentPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip FileMenuStrip;
        private ToolStripMenuItem FileToolStripMenuItem;
        private ToolStripMenuItem CreateToolStripMenuItem;
        private ToolStripMenuItem OpenToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private RichTextBox FileTextRichTextBox;
        private SaveFileDialog SaveFileDialog;
        private OpenFileDialog OpenFileDialog;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem CloseToolStripMenuItem;
        private ToolStripMenuItem FormatToolStripMenuItem;
        private ToolStripMenuItem ColorToolStripMenuItem;
        private ToolStripMenuItem FontToolStripMenuItem;
        private ToolStrip ToolStrip;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem LeftToolStripMenuItem;
        private ToolStripMenuItem CenterToolStripMenuItem;
        private ToolStripMenuItem RightToolStripMenuItem;
        private ToolStripContainer toolStripContainer1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel DatesToolStripStatusLabel;
        private ToolStripStatusLabel DateToolStripStatusLabel;
        private ToolStripStatusLabel TimeToolStripStatusLabel;
        private System.Windows.Forms.Timer timer;
        private ToolStripStatusLabel NumbersToolStripStatusLabel;
    }
}
