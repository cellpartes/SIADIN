Imports CapaNegocios
Imports CapaEntidad
Public Class frmLogin
    Dim lv_operacion As String
    Dim lv_sw As String
    Dim consulta As String
    Dim n As Integer
    Dim lv_idUsuario As String
    Dim lv_Login As String
    Dim lv_Passwd As String
    Dim lv_idNivel As String
    Dim lv_idEmpresa As String
    Dim lv_Nombre As String
    Dim lv_nivel As String
    Dim lv_empresa As String
    Dim cnAccesoDatos As New cnAccesoDatos()

    Private Sub btdOk_Click(sender As Object, e As EventArgs) Handles btdOk.Click
        If txtUsuario.Text = "" Then
            MessageBox.Show("Por Favor ingresar Usuario", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsuario.Select()
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("Por Favor ingresar Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPassword.Select()
        Else
            Dim VerificaLogin As Boolean
            VerificaLogin = cnAccesoDatos.VerificarLogin(txtUsuario.Text, txtPassword.Text)
            If VerificaLogin = True Then
                frmPrincipal.Show()
                Me.Close()
            Else
                MessageBox.Show("Usuario o Contraseña incorrecta", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPassword.Text = ""
                txtPassword.Select()
            End If
        End If
    End Sub

    Private Sub btdCancelar_Click(sender As Object, e As EventArgs) Handles btdCancelar.Click
        Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.CharacterCasing = CharacterCasing.Upper
        txtUsuario.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btdOk_Click(btdOk, e)
        End If
    End Sub

    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtPassword.Select()
        End If
    End Sub
End Class