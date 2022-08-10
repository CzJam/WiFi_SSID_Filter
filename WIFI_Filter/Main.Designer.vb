<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.WifiList = New System.Windows.Forms.TextBox()
        Me.ShowSSID = New System.Windows.Forms.Button()
        Me.ShowAllSSID = New System.Windows.Forms.Button()
        Me.HideSSID = New System.Windows.Forms.Button()
        Me.Author = New System.Windows.Forms.Label()
        Me.Website = New System.Windows.Forms.Label()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.WifiWhiteList = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HideAllSSID = New System.Windows.Forms.Button()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'WifiList
        '
        Me.WifiList.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.WifiList.Location = New System.Drawing.Point(16, 16)
        Me.WifiList.Name = "WifiList"
        Me.WifiList.Size = New System.Drawing.Size(216, 23)
        Me.WifiList.TabIndex = 0
        '
        'ShowSSID
        '
        Me.ShowSSID.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ShowSSID.Location = New System.Drawing.Point(16, 88)
        Me.ShowSSID.Name = "ShowSSID"
        Me.ShowSSID.Size = New System.Drawing.Size(104, 32)
        Me.ShowSSID.TabIndex = 1
        Me.ShowSSID.Text = "显示此SSID"
        Me.ShowSSID.UseVisualStyleBackColor = True
        '
        'ShowAllSSID
        '
        Me.ShowAllSSID.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ShowAllSSID.Location = New System.Drawing.Point(16, 128)
        Me.ShowAllSSID.Name = "ShowAllSSID"
        Me.ShowAllSSID.Size = New System.Drawing.Size(216, 32)
        Me.ShowAllSSID.TabIndex = 2
        Me.ShowAllSSID.Text = "退出白名单模式（全部显示）"
        Me.ShowAllSSID.UseVisualStyleBackColor = True
        '
        'HideSSID
        '
        Me.HideSSID.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.HideSSID.Location = New System.Drawing.Point(128, 88)
        Me.HideSSID.Name = "HideSSID"
        Me.HideSSID.Size = New System.Drawing.Size(104, 32)
        Me.HideSSID.TabIndex = 3
        Me.HideSSID.Text = "隐藏此SSID"
        Me.HideSSID.UseVisualStyleBackColor = True
        '
        'Author
        '
        Me.Author.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Author.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Author.Location = New System.Drawing.Point(16, 168)
        Me.Author.Name = "Author"
        Me.Author.Size = New System.Drawing.Size(128, 24)
        Me.Author.TabIndex = 4
        Me.Author.Text = "B站@晨钟酱Official"
        Me.Author.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Website
        '
        Me.Website.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Website.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Website.Location = New System.Drawing.Point(136, 168)
        Me.Website.Name = "Website"
        Me.Website.Size = New System.Drawing.Size(104, 24)
        Me.Website.TabIndex = 5
        Me.Website.Text = "官网 jamcz.com"
        Me.Website.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.WifiWhiteList)
        Me.GroupBox.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox.Location = New System.Drawing.Point(240, 8)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(216, 184)
        Me.GroupBox.TabIndex = 6
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "WIFI白名单模式列表"
        '
        'WifiWhiteList
        '
        Me.WifiWhiteList.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.WifiWhiteList.Location = New System.Drawing.Point(8, 24)
        Me.WifiWhiteList.Name = "WifiWhiteList"
        Me.WifiWhiteList.Size = New System.Drawing.Size(200, 152)
        Me.WifiWhiteList.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'HideAllSSID
        '
        Me.HideAllSSID.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.HideAllSSID.Location = New System.Drawing.Point(16, 48)
        Me.HideAllSSID.Name = "HideAllSSID"
        Me.HideAllSSID.Size = New System.Drawing.Size(216, 32)
        Me.HideAllSSID.TabIndex = 7
        Me.HideAllSSID.Text = "进入白名单模式（全部隐藏）"
        Me.HideAllSSID.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 200)
        Me.Controls.Add(Me.HideAllSSID)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.Website)
        Me.Controls.Add(Me.Author)
        Me.Controls.Add(Me.HideSSID)
        Me.Controls.Add(Me.ShowAllSSID)
        Me.Controls.Add(Me.ShowSSID)
        Me.Controls.Add(Me.WifiList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WIFI_Filter v1.0"
        Me.GroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WifiList As TextBox
    Friend WithEvents ShowSSID As Button
    Friend WithEvents ShowAllSSID As Button
    Friend WithEvents HideSSID As Button
    Friend WithEvents Author As Label
    Friend WithEvents Website As Label
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents WifiWhiteList As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents HideAllSSID As Button
End Class
