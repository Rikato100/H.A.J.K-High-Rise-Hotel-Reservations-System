Imports MySql.Data.MySqlClient

Public Class AddGuestForm

    Private guestID As Integer = 0

    Public Sub New()

        InitializeComponent()

        guestID = 0

    End Sub

    Public Sub New(id As Integer)

        InitializeComponent()

        guestID = id

    End Sub

    Private Sub AddGuestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbValidIDType.Items.Clear()

        cmbValidIDType.Items.Add("Senior Citizen ID")
        cmbValidIDType.Items.Add("PWD ID")
        cmbValidIDType.Items.Add("Driver's License")
        cmbValidIDType.Items.Add("Passport")
        cmbValidIDType.Items.Add("National ID")
        cmbValidIDType.Items.Add("Other")


        If guestID <> 0 Then
            Me.Text = "Edit Guest"
            lblTitle.Text = "Edit Guest"
            LoadGuestData()
        Else
            Me.Text = "Add Guest"
            lblTitle.Text = "Add Guest"
        End If

    End Sub


    Private Sub LoadGuestData()

        Try

            Using conn As MySqlConnection = DBConnection.GetConnection()

                conn.Open()

                Dim query As String =
                    "SELECT surname, firstname, middlename, contact, " &
                    "email, valid_id_type, valid_id_number " &
                    "FROM guest " &
                    "WHERE guest_id = @guestID"

                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue("@guestID", guestID)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.Read() Then

                            txtSurname.Text =
                                reader("surname").ToString()

                            txtFirstName.Text =
                                reader("firstname").ToString()

                            txtMiddle.Text =
                                reader("middlename").ToString()

                            txtContact.Text =
                                reader("contact").ToString()

                            txtEmail.Text =
                                reader("email").ToString()

                            cmbValidIDType.Text =
                                reader("valid_id_type").ToString()

                            txtValidIDNumber.Text =
                                reader("valid_id_number").ToString()

                        End If

                    End Using

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Error loading guest: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtSurname.Text.Trim() = "" Then

            MessageBox.Show("Please enter the surname.")
            Exit Sub

        End If


        If txtFirstName.Text.Trim() = "" Then

            MessageBox.Show("Please enter the first name.")
            Exit Sub

        End If


        If txtContact.Text.Trim() = "" Then

            MessageBox.Show("Please enter the contact number.")
            Exit Sub

        End If


        Try

            Using conn As MySqlConnection = DBConnection.GetConnection()

                conn.Open()

                Dim query As String

                If guestID = 0 Then

                    query =
                        "INSERT INTO guest " &
                        "(surname, firstname, middlename, contact, email, " &
                        "valid_id_type, valid_id_number) " &
                        "VALUES " &
                        "(@surname, @firstname, @middlename, @contact, " &
                        "@email, @idType, @idNumber)"


                Else

                    query =
                        "UPDATE guest SET " &
                        "surname = @surname, " &
                        "firstname = @firstname, " &
                        "middlename = @middlename, " &
                        "contact = @contact, " &
                        "email = @email, " &
                        "valid_id_type = @idType, " &
                        "valid_id_number = @idNumber " &
                        "WHERE guest_id = @guestID"

                End If


                Using cmd As New MySqlCommand(query, conn)

                    cmd.Parameters.AddWithValue(
                        "@surname",
                        txtSurname.Text.Trim()
                    )

                    cmd.Parameters.AddWithValue(
                        "@firstname",
                        txtFirstName.Text.Trim()
                    )

                    cmd.Parameters.AddWithValue(
                        "@middlename",
                        txtMiddle.Text.Trim()
                    )

                    cmd.Parameters.AddWithValue(
                        "@contact",
                        txtContact.Text.Trim()
                    )

                    cmd.Parameters.AddWithValue(
                        "@email",
                        txtEmail.Text.Trim()
                    )

                    cmd.Parameters.AddWithValue(
                        "@idType",
                        cmbValidIDType.Text
                    )

                    cmd.Parameters.AddWithValue(
                        "@idNumber",
                        txtValidIDNumber.Text.Trim()
                    )


                    If guestID <> 0 Then

                        cmd.Parameters.AddWithValue(
                            "@guestID",
                            guestID
                        )

                    End If


                    cmd.ExecuteNonQuery()

                End Using

            End Using


            If guestID = 0 Then

                MessageBox.Show(
                    "Guest added successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

            Else

                MessageBox.Show(
                    "Guest updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

            End If

            Me.DialogResult = DialogResult.OK

            Me.Close()


        Catch ex As Exception

            MessageBox.Show(
                "Error saving guest: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.DialogResult = DialogResult.Cancel

        Me.Close()

    End Sub

End Class