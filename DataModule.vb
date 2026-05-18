Imports MySqlConnector

Module DataModule
    Public SessionUsername As String = ""
    ' --- BAGIAN LAYANAN (MASTER) ---
    Public Function TampilLayanan() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM tb_layanan ORDER BY id_layanan ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal ambil data layanan: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function SimpanLayanan(id As String, nama As String, harga As Integer, k1 As String, k2 As String, k3 As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tb_layanan (id_layanan, nama_layanan, harga_dasar, kesulitan1, kesulitan2, kesulitan3) VALUES (@id, @nama, @harga, @k1, @k2, @k3)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@k1", k1)
                    cmd.Parameters.AddWithValue("@k2", k2)
                    cmd.Parameters.AddWithValue("@k3", k3)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal simpan layanan: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UbahLayanan(id As String, nama As String, harga As Integer, k1 As String, k2 As String, k3 As String) As Boolean
        Try
            Dim query As String = "UPDATE tb_layanan SET nama_layanan=@nama, harga_dasar=@harga, kesulitan1=@k1, kesulitan2=@k2, kesulitan3=@k3 WHERE id_layanan=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.Parameters.AddWithValue("@k1", k1)
                    cmd.Parameters.AddWithValue("@k2", k2)
                    cmd.Parameters.AddWithValue("@k3", k3)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal update layanan: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function HapusLayanan(id As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tb_layanan WHERE id_layanan=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal hapus layanan: " & ex.Message)
            Return False
        End Try
    End Function

    ' --- BAGIAN JOKI (TRANSAKSI) ---
    Public Function TampilJoki() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT j.uid, j.username, j.password, j.detail, j.kesulitan, " &
                             "l.nama_layanan AS 'Jenis Layanan', " &
                             "s.nama_status AS 'Status', " &
                             "j.total_harga " &
                             "FROM tb_joki j " &
                             "INNER JOIN tb_layanan l ON j.id_layanan = l.id_layanan " &
                             "INNER JOIN tb_status s ON j.id_status = s.id_status " &
                             "ORDER BY j.uid ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal tampil data: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function SimpanJoki(uid As String, user As String, pass As String, detail As String, id_lay As String, sulit As Integer, total As Integer) As Boolean
        Try
            Dim query As String = "INSERT INTO tb_joki (uid, username, password, detail, id_layanan, kesulitan, total_harga, id_status) " &
                              "VALUES (@uid, @user, @pass, @detail, @id_lay, @sulit, @total, 1)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@uid", uid)
                    cmd.Parameters.AddWithValue("@user", user)
                    cmd.Parameters.AddWithValue("@pass", pass)
                    cmd.Parameters.AddWithValue("@detail", detail)
                    cmd.Parameters.AddWithValue("@id_lay", id_lay)
                    cmd.Parameters.AddWithValue("@sulit", sulit)
                    cmd.Parameters.AddWithValue("@total", total)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal simpan: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UbahJoki(uid As String, user As String, pass As String, detail As String, id_lay As String, sulit As Integer, total As Integer) As Boolean
        Try
            Dim query As String = "UPDATE tb_joki SET username=@user, password=@pass, detail=@detail, id_layanan=@id_lay, kesulitan=@sulit, total_harga=@total WHERE uid=@uid"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@uid", uid)
                    cmd.Parameters.AddWithValue("@user", user)
                    cmd.Parameters.AddWithValue("@pass", pass)
                    cmd.Parameters.AddWithValue("@detail", detail)
                    cmd.Parameters.AddWithValue("@id_lay", id_lay)
                    cmd.Parameters.AddWithValue("@sulit", sulit)
                    cmd.Parameters.AddWithValue("@total", total)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal update data: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function HapusJoki(uid As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tb_joki WHERE uid=@uid"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@uid", uid)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal hapus data: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function CariJoki(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT j.uid, j.username, j.password, j.detail, l.nama_layanan AS 'Jenis Layanan', j.kesulitan, j.total_harga " &
                                 "FROM tb_joki j INNER JOIN tb_layanan l ON j.id_layanan = l.id_layanan " &
                                 "WHERE j.uid LIKE @key OR j.username LIKE @key OR j.detail LIKE @key OR l.nama_layanan LIKE @key"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function GetLayananForCombo() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT id_layanan, nama_layanan, kesulitan1, kesulitan2, kesulitan3 FROM tb_layanan"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat list layanan: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Function UpdateStatusJoki(uid As String, id_status As String) As Boolean
        Try
            Dim query As String = "UPDATE tb_joki SET id_status=@id_status WHERE uid=@uid"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@uid", uid)
                    cmd.Parameters.AddWithValue("@id_status", id_status)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal update status: " & ex.Message)
            Return False
        End Try
    End Function

    ' --- BAGIAN AUTENTIKASI ---
    Public Function LoginUser(username As String, password As String) As String
        Try
            Dim query As String = "SELECT role FROM tb_user WHERE username = @username AND password = @password LIMIT 1"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                        Return result.ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ""
    End Function

    Public Function RegisterUser(username As String, password As String, role As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tb_user (username, password, role) VALUES (@username, @password, @role)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    cmd.Parameters.AddWithValue("@role", role)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal register: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function CekUsernameAda(username As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tb_user WHERE username = @username"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    Dim count = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal cek username: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return False
    End Function

    Public Function HitungTotalPendapatan() As Integer
        Dim total As Integer = 0
        Try
            Dim query As String = "SELECT SUM(total_harga) FROM tb_joki WHERE id_status = 3"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot DBNull.Value Then total = Convert.ToInt32(result)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal hitung pendapatan: " & ex.Message)
        End Try
        Return total
    End Function
    Public Function CekPesananAktifUser(pemesan As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tb_joki WHERE username_pemesan = @pemesan AND id_status IN (1, 2)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@pemesan", pemesan)
                    Dim count = Convert.ToInt32(cmd.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal cek status pesanan: " & ex.Message)
        End Try
        Return False
    End Function
    Public Function BuatPesananUser(uid As String, user As String, pass As String, detail As String, id_lay As String, sulit As Integer, total As Integer, pemesan As String, idTransaksi As String, idMetode As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tb_joki (uid, id_transaksi, id_metode, username, password, detail, id_layanan, kesulitan, total_harga, id_status, username_pemesan) " &
                                  "VALUES (@uid, @id_transaksi, @id_metode, @user, @pass, @detail, @id_lay, @sulit, @total, 1, @pemesan) " &
                                  "ON DUPLICATE KEY UPDATE id_transaksi=@id_transaksi, id_metode=@id_metode, username=@user, password=@pass, detail=@detail, id_layanan=@id_lay, kesulitan=@sulit, total_harga=@total, id_status=1, username_pemesan=@pemesan, tgl_order=CURRENT_TIMESTAMP"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@uid", uid)
                    cmd.Parameters.AddWithValue("@id_transaksi", idTransaksi)
                    cmd.Parameters.AddWithValue("@id_metode", idMetode)
                    cmd.Parameters.AddWithValue("@user", user)
                    cmd.Parameters.AddWithValue("@pass", pass)
                    cmd.Parameters.AddWithValue("@detail", detail)
                    cmd.Parameters.AddWithValue("@id_lay", id_lay)
                    cmd.Parameters.AddWithValue("@sulit", sulit)
                    cmd.Parameters.AddWithValue("@total", total)
                    cmd.Parameters.AddWithValue("@pemesan", pemesan)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal mengirim pesanan: " & ex.Message)
            Return False
        End Try
    End Function
    Public Function TampilJokiUser(pemesan As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT j.uid, j.id_transaksi, j.username, j.password, j.detail, " &
                                  "l.nama_layanan AS 'Jenis Layanan', l.harga_dasar, j.kesulitan, j.tgl_order, " &
                                  "m.nama_metode AS 'Metode Bayar', " &
                                  "s.nama_status AS 'Status', j.total_harga " &
                                  "FROM tb_joki j " &
                                  "INNER JOIN tb_layanan l ON j.id_layanan = l.id_layanan " &
                                  "INNER JOIN tb_status s ON j.id_status = s.id_status " &
                                  "LEFT JOIN tb_metode m ON j.id_metode = m.id_metode " &
                                  "WHERE j.username_pemesan = @pemesan " &
                                  "ORDER BY j.tgl_order DESC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@pemesan", pemesan)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal ambil data joki user: " & ex.Message)
        End Try

        Return dt
    End Function

    Public Function GenerateIDTransaksi() As String
        Dim idBaru As String = ""
        Dim tglHariIni As String = DateTime.Now.ToString("yyyyMMdd")
        Dim prefix As String = "TRX-" & tglHariIni & "-"

        Try
            Dim query As String = "SELECT id_transaksi FROM tb_joki WHERE id_transaksi LIKE @prefix ORDER BY id_transaksi DESC LIMIT 1"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@prefix", prefix & "%")
                    Dim lastId As Object = cmd.ExecuteScalar()

                    If lastId IsNot Nothing AndAlso lastId IsNot DBNull.Value Then
                        Dim lastUrutan As Integer = Convert.ToInt32(lastId.ToString().Substring(13, 3))
                        Dim urutanBaru As Integer = lastUrutan + 1
                        idBaru = prefix & urutanBaru.ToString("D3")
                    Else
                        idBaru = prefix & "001"
                    End If
                End Using
            End Using
        Catch ex As Exception
            idBaru = prefix & DateTime.Now.ToString("HHmmss")
        End Try

        Return idBaru
    End Function

    Public Function GetMetodeForCombo() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT id_metode, nama_metode FROM tb_metode"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memuat list metode pembayaran: " & ex.Message)
        End Try
        Return dt
    End Function

End Module

