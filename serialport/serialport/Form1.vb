'Yazılım Geliştirme By ROBİMEK - 2015
'Yazılım Lisans By ROBİMEK
'sistem kütüphaneleri
Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports


Public Class frmMain
    Dim myPort As Array 'port ismi tanımlama
    Delegate Sub SetTextCallback(ByVal [text] As String)

    'klavye tuşları atama
    Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Button1.PerformClick()
            Button2.BackColor = Color.Red
            TextBox3.ForeColor = Color.Green
            Label10.Text = "RECEIVING DATA..."

        Else
            Button1.BackColor = Color.Green


        End If
        If (e.KeyCode = Keys.Space) Then

            Button2.PerformClick()
            Button1.BackColor = Color.Green
            TextBox3.ForeColor = Color.Red
            Label11.Text = "Stopped."
        Else
            Button2.BackColor = Color.Red


        End If
      
    End Sub

    'serial port ve baundrate ayarları
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBox2.Items.Add(9600)
        ComboBox2.Items.Add(19200)
        ComboBox2.Items.Add(38400)
        ComboBox2.Items.Add(57600)
        ComboBox2.Items.Add(115200)
        For i = 0 To UBound(myPort)
            ComboBox1.Items.Add(myPort(i))
        Next
        ComboBox1.Text = ComboBox1.Items.Item(0)
        ComboBox2.Text = ComboBox2.Items.Item(0)
        Button2.Enabled = False
    End Sub

    'porta bağlan butonu 
    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()

        SerialPort1.PortName = ComboBox1.Text
        SerialPort1.BaudRate = ComboBox2.Text
        SerialPort1.Parity = IO.Ports.Parity.None
        SerialPort1.StopBits = IO.Ports.StopBits.One
        SerialPort1.DataBits = 8
        SerialPort1.Open()
        Label10.Text = "Connected"
        Button1.Enabled = False
        Button2.Enabled = True
        TextBox4.ForeColor = Color.Green
        Label11.Text = "Receiving data..."


    End Sub

    'bağlantı kes butonu
    Private Sub btnDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Stop()
        SerialPort1.Close()
        Button1.Enabled = True
        Button2.Enabled = False
        TextBox3.ForeColor = Color.Red
        Label10.Text = "Disconnected."
        Label11.Text = "Stopped."
    End Sub
   
    Private Sub cmbPort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If SerialPort1.IsOpen = False Then
            SerialPort1.PortName = ComboBox1.Text
        Else
            MsgBox("You can't change this while port is open", vbCritical)
        End If
    End Sub
    'baudrate seçimi
    Private Sub cmbBaud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If SerialPort1.IsOpen = False Then
            SerialPort1.BaudRate = ComboBox2.Text
        Else
            MsgBox("You can't change this while port is open", vbCritical)
        End If
    End Sub

    'zamanlayıcı portta veri gönderme ve portu okuma
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim receiveddata As String = SerialPort1.ReadLine() 'serial portu okuma ve datayı yazdırma

        Label7.Text = receiveddata


        System.Threading.Thread.Sleep(149)
        Dim integerVal As String = SerialPort1.ReadLine()
        integerVal = Convert.ToInt32(integerVal)
        AGauge1.Value = integerVal


        System.Threading.Thread.Sleep(149)
        Dim receiveddata2 As String = SerialPort1.ReadLine()

        Label8.Text = receiveddata2

        AGauge2.Value = receiveddata2

        System.Threading.Thread.Sleep(149)

    End Sub

    'çıkış butonu
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        End

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        SerialPort1.Write("a")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        SerialPort1.Write("z")
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
End Class
