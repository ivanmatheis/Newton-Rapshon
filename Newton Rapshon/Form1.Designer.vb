<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Salida = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lf = New System.Windows.Forms.Label()
        Me.la = New System.Windows.Forms.Label()
        Me.lc = New System.Windows.Forms.Label()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.ta = New System.Windows.Forms.TextBox()
        Me.tc = New System.Windows.Forms.TextBox()
        Me.Graficar = New System.Windows.Forms.Button()
        Me.Limpiar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tr = New System.Windows.Forms.TextBox()
        Me.ld = New System.Windows.Forms.Label()
        Me.td = New System.Windows.Forms.TextBox()
        Me.Graf = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tb = New System.Windows.Forms.TextBox()
        Me.lb = New System.Windows.Forms.Label()
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Graf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Salida
        '
        Me.Salida.BackgroundColor = System.Drawing.Color.LightCoral
        Me.Salida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Salida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.Salida.Location = New System.Drawing.Point(520, 31)
        Me.Salida.Name = "Salida"
        Me.Salida.Size = New System.Drawing.Size(342, 150)
        Me.Salida.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.HeaderText = "Índice "
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "xi"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "error"
        Me.Column3.Name = "Column3"
        '
        'Calcular
        '
        Me.Calcular.Location = New System.Drawing.Point(419, 34)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 9
        Me.Calcular.Text = "&Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Salir.Location = New System.Drawing.Point(419, 160)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 10
        Me.Salir.Text = "&Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(257, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "La formula es la siguiente"
        '
        'lf
        '
        Me.lf.AutoSize = True
        Me.lf.Location = New System.Drawing.Point(24, 31)
        Me.lf.Name = "lf"
        Me.lf.Size = New System.Drawing.Size(73, 13)
        Me.lf.TabIndex = 13
        Me.lf.Text = "Dame función"
        '
        'la
        '
        Me.la.AutoSize = True
        Me.la.Location = New System.Drawing.Point(24, 101)
        Me.la.Name = "la"
        Me.la.Size = New System.Drawing.Size(44, 13)
        Me.la.TabIndex = 14
        Me.la.Text = "Dame a"
        '
        'lc
        '
        Me.lc.AutoSize = True
        Me.lc.Location = New System.Drawing.Point(24, 153)
        Me.lc.Name = "lc"
        Me.lc.Size = New System.Drawing.Size(63, 13)
        Me.lc.TabIndex = 16
        Me.lc.Text = "Dame cifras"
        '
        'tf
        '
        Me.tf.BackColor = System.Drawing.Color.Pink
        Me.tf.Location = New System.Drawing.Point(123, 31)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(100, 20)
        Me.tf.TabIndex = 17
        '
        'ta
        '
        Me.ta.BackColor = System.Drawing.Color.Pink
        Me.ta.Location = New System.Drawing.Point(123, 98)
        Me.ta.Name = "ta"
        Me.ta.Size = New System.Drawing.Size(100, 20)
        Me.ta.TabIndex = 18
        '
        'tc
        '
        Me.tc.BackColor = System.Drawing.Color.Pink
        Me.tc.Location = New System.Drawing.Point(123, 150)
        Me.tc.Name = "tc"
        Me.tc.Size = New System.Drawing.Size(100, 20)
        Me.tc.TabIndex = 20
        '
        'Graficar
        '
        Me.Graficar.Location = New System.Drawing.Point(419, 71)
        Me.Graficar.Name = "Graficar"
        Me.Graficar.Size = New System.Drawing.Size(75, 23)
        Me.Graficar.TabIndex = 21
        Me.Graficar.Text = "&Graficar"
        Me.Graficar.UseVisualStyleBackColor = True
        '
        'Limpiar
        '
        Me.Limpiar.Location = New System.Drawing.Point(419, 118)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Limpiar.TabIndex = 22
        Me.Limpiar.Text = "&Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "La raíz aproximada es: "
        '
        'Tr
        '
        Me.Tr.BackColor = System.Drawing.Color.Pink
        Me.Tr.Location = New System.Drawing.Point(123, 185)
        Me.Tr.Name = "Tr"
        Me.Tr.Size = New System.Drawing.Size(112, 20)
        Me.Tr.TabIndex = 24
        '
        'ld
        '
        Me.ld.AutoSize = True
        Me.ld.Location = New System.Drawing.Point(24, 65)
        Me.ld.Name = "ld"
        Me.ld.Size = New System.Drawing.Size(93, 13)
        Me.ld.TabIndex = 25
        Me.ld.Text = "Dame su derivada"
        '
        'td
        '
        Me.td.BackColor = System.Drawing.Color.Pink
        Me.td.Location = New System.Drawing.Point(123, 62)
        Me.td.Name = "td"
        Me.td.Size = New System.Drawing.Size(100, 20)
        Me.td.TabIndex = 26
        '
        'Graf
        '
        Me.Graf.BackColor = System.Drawing.Color.Salmon
        ChartArea3.Name = "ChartArea1"
        Me.Graf.ChartAreas.Add(ChartArea3)
        Me.Graf.Cursor = System.Windows.Forms.Cursors.Default
        Legend3.Name = "Legend1"
        Me.Graf.Legends.Add(Legend3)
        Me.Graf.Location = New System.Drawing.Point(147, 287)
        Me.Graf.Name = "Graf"
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series5.Legend = "Legend1"
        Series5.Name = "Series1"
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series6.Legend = "Legend1"
        Series6.Name = "Series2"
        Me.Graf.Series.Add(Series5)
        Me.Graf.Series.Add(Series6)
        Me.Graf.Size = New System.Drawing.Size(635, 300)
        Me.Graf.TabIndex = 27
        Me.Graf.Text = "Chart1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Newton_Rapshon.My.Resources.Resources.formula_rosa
        Me.PictureBox1.Location = New System.Drawing.Point(240, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(163, 56)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'tb
        '
        Me.tb.BackColor = System.Drawing.Color.Pink
        Me.tb.Location = New System.Drawing.Point(123, 124)
        Me.tb.Name = "tb"
        Me.tb.Size = New System.Drawing.Size(100, 20)
        Me.tb.TabIndex = 28
        '
        'lb
        '
        Me.lb.AutoSize = True
        Me.lb.Location = New System.Drawing.Point(24, 127)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(44, 13)
        Me.lb.TabIndex = 29
        Me.lb.Text = "Dame b"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(895, 633)
        Me.Controls.Add(Me.lb)
        Me.Controls.Add(Me.tb)
        Me.Controls.Add(Me.Graf)
        Me.Controls.Add(Me.td)
        Me.Controls.Add(Me.ld)
        Me.Controls.Add(Me.Tr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Graficar)
        Me.Controls.Add(Me.tc)
        Me.Controls.Add(Me.ta)
        Me.Controls.Add(Me.tf)
        Me.Controls.Add(Me.lc)
        Me.Controls.Add(Me.la)
        Me.Controls.Add(Me.lf)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.Salida)
        Me.Name = "Form1"
        Me.Text = "Newton Rapshon"
        CType(Me.Salida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Graf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Salida As DataGridView
    Friend WithEvents Calcular As Button
    Friend WithEvents Salir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lf As Label
    Friend WithEvents la As Label
    Friend WithEvents lc As Label
    Friend WithEvents tf As TextBox
    Friend WithEvents ta As TextBox
    Friend WithEvents tc As TextBox
    Friend WithEvents Graficar As Button
    Friend WithEvents Limpiar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Tr As TextBox
    Friend WithEvents ld As Label
    Friend WithEvents td As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Graf As DataVisualization.Charting.Chart
    Friend WithEvents tb As TextBox
    Friend WithEvents lb As Label
End Class
