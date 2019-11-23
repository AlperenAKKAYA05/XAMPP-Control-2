<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.FalseApache = New System.Windows.Forms.PictureBox()
        Me.FalseMySQL = New System.Windows.Forms.PictureBox()
        Me.TrueApache = New System.Windows.Forms.PictureBox()
        Me.TrueMySQL = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GirişToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UyarıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÇıkışToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÇıkışToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.FalseApache, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FalseMySQL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrueApache, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrueMySQL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(36, 12)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(63, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Apache"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(36, 35)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(61, 17)
        Me.CheckBox2.TabIndex = 4
        Me.CheckBox2.Text = "MySQL"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'FalseApache
        '
        Me.FalseApache.Image = Global.xampp_control_2.My.Resources.Resources._False
        Me.FalseApache.Location = New System.Drawing.Point(94, 2)
        Me.FalseApache.Name = "FalseApache"
        Me.FalseApache.Size = New System.Drawing.Size(21, 27)
        Me.FalseApache.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FalseApache.TabIndex = 5
        Me.FalseApache.TabStop = False
        '
        'FalseMySQL
        '
        Me.FalseMySQL.Image = Global.xampp_control_2.My.Resources.Resources._False
        Me.FalseMySQL.Location = New System.Drawing.Point(94, 25)
        Me.FalseMySQL.Name = "FalseMySQL"
        Me.FalseMySQL.Size = New System.Drawing.Size(21, 27)
        Me.FalseMySQL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FalseMySQL.TabIndex = 6
        Me.FalseMySQL.TabStop = False
        '
        'TrueApache
        '
        Me.TrueApache.Image = Global.xampp_control_2.My.Resources.Resources._True
        Me.TrueApache.Location = New System.Drawing.Point(94, 2)
        Me.TrueApache.Name = "TrueApache"
        Me.TrueApache.Size = New System.Drawing.Size(21, 27)
        Me.TrueApache.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TrueApache.TabIndex = 7
        Me.TrueApache.TabStop = False
        '
        'TrueMySQL
        '
        Me.TrueMySQL.Image = Global.xampp_control_2.My.Resources.Resources._True
        Me.TrueMySQL.Location = New System.Drawing.Point(94, 25)
        Me.TrueMySQL.Name = "TrueMySQL"
        Me.TrueMySQL.Size = New System.Drawing.Size(21, 27)
        Me.TrueMySQL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.TrueMySQL.TabIndex = 8
        Me.TrueMySQL.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Apache | Off"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(121, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "MySQL | Off"
        '
        'NotifyIcon
        '
        Me.NotifyIcon.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "NotifyIcon"
        Me.NotifyIcon.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GirişToolStripMenuItem, Me.UyarıToolStripMenuItem, Me.ÇıkışToolStripMenuItem, Me.ÇıkışToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(109, 92)
        '
        'GirişToolStripMenuItem
        '
        Me.GirişToolStripMenuItem.Name = "GirişToolStripMenuItem"
        Me.GirişToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.GirişToolStripMenuItem.Text = "Gizle"
        '
        'UyarıToolStripMenuItem
        '
        Me.UyarıToolStripMenuItem.Name = "UyarıToolStripMenuItem"
        Me.UyarıToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.UyarıToolStripMenuItem.Text = "Göster"
        '
        'ÇıkışToolStripMenuItem
        '
        Me.ÇıkışToolStripMenuItem.Name = "ÇıkışToolStripMenuItem"
        Me.ÇıkışToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.ÇıkışToolStripMenuItem.Text = "Uyarı"
        '
        'ÇıkışToolStripMenuItem1
        '
        Me.ÇıkışToolStripMenuItem1.Name = "ÇıkışToolStripMenuItem1"
        Me.ÇıkışToolStripMenuItem1.Size = New System.Drawing.Size(108, 22)
        Me.ÇıkışToolStripMenuItem1.Text = "Çıkış"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 61)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TrueMySQL)
        Me.Controls.Add(Me.TrueApache)
        Me.Controls.Add(Me.FalseMySQL)
        Me.Controls.Add(Me.FalseApache)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(247, 100)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(247, 100)
        Me.Name = "Form1"
        Me.Text = "XAMPP Control 2"
        CType(Me.FalseApache, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FalseMySQL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrueApache, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrueMySQL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub txtOutput_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents FalseApache As PictureBox
    Friend WithEvents FalseMySQL As PictureBox
    Friend WithEvents TrueApache As PictureBox
    Friend WithEvents TrueMySQL As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Private WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents GirişToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UyarıToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÇıkışToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÇıkışToolStripMenuItem1 As ToolStripMenuItem
End Class
