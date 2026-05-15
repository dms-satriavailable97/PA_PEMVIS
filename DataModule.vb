Imports MySqlConnector

Module DataModule
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

    Public Function SimpanLayanan(id As String, nama As String, harga As Integer) As Boolean
        Try
            Dim query As String = "INSERT INTO tb_layanan VALUES (@id, @nama, @harga)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@harga", harga)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal simpan layanan: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function UbahLayanan(id As String, nama As String, harga As Integer) As Boolean
        Try
            Dim query As String = "UPDATE tb_layanan SET nama_layanan=@nama, harga_dasar=@harga WHERE id_layanan=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@harga", harga)
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
            ' Perhatikan penambahan tanda koma setelah j.kesulitan
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
            Dim query As String = "SELECT id_layanan, nama_layanan FROM tb_layanan"
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

    ' Fungsi Update Status
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

    ' Fungsi Hitung Pendapatan (Hanya yang berstatus 'Selesai' / ID 3)
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
End Module