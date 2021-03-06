namespace hanyu
{
    partial class MainWindow
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ctlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ctlCerts = new System.Windows.Forms.ListView();
            this.ctlCertsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctlCertsType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctlCertsNotAfter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctlCertsDrive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctlCertsCA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctlRefresh = new System.Windows.Forms.Button();
            this.ctlCertsListDesc = new System.Windows.Forms.Label();
            this.ctlContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctlCheckPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlSep0 = new System.Windows.Forms.ToolStripSeparator();
            this.ctlCertCopyTo = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctlCertDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlCertMoveTo = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlCopyRight = new System.Windows.Forms.Label();
            this.ctlPanel.SuspendLayout();
            this.ctlContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlPanel
            // 
            this.ctlPanel.ColumnCount = 2;
            this.ctlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ctlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ctlPanel.Controls.Add(this.ctlCerts, 0, 1);
            this.ctlPanel.Controls.Add(this.ctlRefresh, 0, 2);
            this.ctlPanel.Controls.Add(this.ctlCertsListDesc, 0, 0);
            this.ctlPanel.Controls.Add(this.ctlCopyRight, 1, 0);
            this.ctlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlPanel.Location = new System.Drawing.Point(0, 0);
            this.ctlPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ctlPanel.Name = "ctlPanel";
            this.ctlPanel.Padding = new System.Windows.Forms.Padding(3);
            this.ctlPanel.RowCount = 3;
            this.ctlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ctlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ctlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ctlPanel.Size = new System.Drawing.Size(395, 196);
            this.ctlPanel.TabIndex = 0;
            // 
            // ctlCerts
            // 
            this.ctlCerts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ctlCertsName,
            this.ctlCertsType,
            this.ctlCertsNotAfter,
            this.ctlCertsDrive,
            this.ctlCertsCA});
            this.ctlPanel.SetColumnSpan(this.ctlCerts, 2);
            this.ctlCerts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlCerts.FullRowSelect = true;
            this.ctlCerts.GridLines = true;
            this.ctlCerts.Location = new System.Drawing.Point(3, 21);
            this.ctlCerts.Margin = new System.Windows.Forms.Padding(0);
            this.ctlCerts.MultiSelect = false;
            this.ctlCerts.Name = "ctlCerts";
            this.ctlCerts.ShowGroups = false;
            this.ctlCerts.Size = new System.Drawing.Size(389, 142);
            this.ctlCerts.TabIndex = 1;
            this.ctlCerts.UseCompatibleStateImageBehavior = false;
            this.ctlCerts.View = System.Windows.Forms.View.Details;
            this.ctlCerts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ctlCerts_MouseClick);
            // 
            // ctlCertsName
            // 
            this.ctlCertsName.Text = "이름";
            this.ctlCertsName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ctlCertsName.Width = 80;
            // 
            // ctlCertsType
            // 
            this.ctlCertsType.Text = "종류";
            this.ctlCertsType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ctlCertsType.Width = 70;
            // 
            // ctlCertsNotAfter
            // 
            this.ctlCertsNotAfter.Text = "유효기간";
            this.ctlCertsNotAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ctlCertsNotAfter.Width = 70;
            // 
            // ctlCertsDrive
            // 
            this.ctlCertsDrive.Text = "위치";
            this.ctlCertsDrive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ctlCertsDrive.Width = 50;
            // 
            // ctlCertsCA
            // 
            this.ctlCertsCA.Text = "발급자";
            this.ctlCertsCA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ctlCertsCA.Width = 90;
            // 
            // ctlRefresh
            // 
            this.ctlRefresh.AutoSize = true;
            this.ctlRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctlRefresh.Location = new System.Drawing.Point(3, 166);
            this.ctlRefresh.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.ctlRefresh.Name = "ctlRefresh";
            this.ctlRefresh.Padding = new System.Windows.Forms.Padding(20, 1, 20, 1);
            this.ctlRefresh.Size = new System.Drawing.Size(288, 27);
            this.ctlRefresh.TabIndex = 2;
            this.ctlRefresh.Text = "갱신";
            this.ctlRefresh.UseVisualStyleBackColor = true;
            this.ctlRefresh.Click += new System.EventHandler(this.ctlRefresh_Click);
            // 
            // ctlCertsListDesc
            // 
            this.ctlCertsListDesc.AutoSize = true;
            this.ctlCertsListDesc.Location = new System.Drawing.Point(3, 3);
            this.ctlCertsListDesc.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ctlCertsListDesc.Name = "ctlCertsListDesc";
            this.ctlCertsListDesc.Size = new System.Drawing.Size(101, 15);
            this.ctlCertsListDesc.TabIndex = 3;
            this.ctlCertsListDesc.Text = "설치된 인증서 : 0";
            // 
            // ctlContextMenu
            // 
            this.ctlContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlCheckPassword,
            this.ctlChangePassword,
            this.ctlSep0,
            this.ctlCertMoveTo,
            this.ctlCertCopyTo,
            this.ctlSep1,
            this.ctlCertDelete});
            this.ctlContextMenu.Name = "contextMenuStrip1";
            this.ctlContextMenu.Size = new System.Drawing.Size(151, 126);
            // 
            // ctlCheckPassword
            // 
            this.ctlCheckPassword.Name = "ctlCheckPassword";
            this.ctlCheckPassword.Size = new System.Drawing.Size(180, 22);
            this.ctlCheckPassword.Text = "비밀번호 확인";
            this.ctlCheckPassword.Click += new System.EventHandler(this.ctlCheckPassword_Click);
            // 
            // ctlChangePassword
            // 
            this.ctlChangePassword.Name = "ctlChangePassword";
            this.ctlChangePassword.Size = new System.Drawing.Size(180, 22);
            this.ctlChangePassword.Text = "비밀번호 변경";
            this.ctlChangePassword.Click += new System.EventHandler(this.ctlChangePassword_Click);
            // 
            // ctlSep0
            // 
            this.ctlSep0.Name = "ctlSep0";
            this.ctlSep0.Size = new System.Drawing.Size(177, 6);
            // 
            // ctlCertCopyTo
            // 
            this.ctlCertCopyTo.Name = "ctlCertCopyTo";
            this.ctlCertCopyTo.Size = new System.Drawing.Size(180, 22);
            this.ctlCertCopyTo.Text = "인증서 복사";
            this.ctlCertCopyTo.Click += new System.EventHandler(this.ctlCertCopyTo_Click);
            // 
            // ctlSep1
            // 
            this.ctlSep1.Name = "ctlSep1";
            this.ctlSep1.Size = new System.Drawing.Size(177, 6);
            // 
            // ctlCertDelete
            // 
            this.ctlCertDelete.Name = "ctlCertDelete";
            this.ctlCertDelete.Size = new System.Drawing.Size(180, 22);
            this.ctlCertDelete.Text = "인증서 삭제";
            this.ctlCertDelete.Click += new System.EventHandler(this.ctlCertDelete_Click);
            // 
            // ctlCertMoveTo
            // 
            this.ctlCertMoveTo.Name = "ctlCertMoveTo";
            this.ctlCertMoveTo.Size = new System.Drawing.Size(180, 22);
            this.ctlCertMoveTo.Text = "인증서 이동";
            this.ctlCertMoveTo.Click += new System.EventHandler(this.ctlCertMoveTo_Click);
            // 
            // ctlCopyRight
            // 
            this.ctlCopyRight.AutoSize = true;
            this.ctlCopyRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ctlCopyRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.ctlCopyRight.Location = new System.Drawing.Point(310, 3);
            this.ctlCopyRight.Name = "ctlCopyRight";
            this.ctlCopyRight.Size = new System.Drawing.Size(79, 18);
            this.ctlCopyRight.TabIndex = 4;
            this.ctlCopyRight.Text = "By RyuaNerin";
            this.ctlCopyRight.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ctlCopyRight.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ctlCopyRight_MouseDoubleClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 196);
            this.Controls.Add(this.ctlPanel);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(360, 220);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "하뉴";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ctlPanel.ResumeLayout(false);
            this.ctlPanel.PerformLayout();
            this.ctlContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ctlPanel;
        private System.Windows.Forms.ListView ctlCerts;
        private System.Windows.Forms.ColumnHeader ctlCertsName;
        private System.Windows.Forms.ColumnHeader ctlCertsNotAfter;
        private System.Windows.Forms.ColumnHeader ctlCertsDrive;
        private System.Windows.Forms.Button ctlRefresh;
        private System.Windows.Forms.Label ctlCertsListDesc;
        private System.Windows.Forms.ColumnHeader ctlCertsType;
        private System.Windows.Forms.ContextMenuStrip ctlContextMenu;
        private System.Windows.Forms.ToolStripMenuItem ctlCheckPassword;
        private System.Windows.Forms.ToolStripMenuItem ctlChangePassword;
        private System.Windows.Forms.ToolStripSeparator ctlSep0;
        private System.Windows.Forms.ToolStripMenuItem ctlCertCopyTo;
        private System.Windows.Forms.ToolStripSeparator ctlSep1;
        private System.Windows.Forms.ToolStripMenuItem ctlCertDelete;
        private System.Windows.Forms.ColumnHeader ctlCertsCA;
        private System.Windows.Forms.ToolStripMenuItem ctlCertMoveTo;
        private System.Windows.Forms.Label ctlCopyRight;
    }
}

