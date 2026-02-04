Imports System
Imports System.Collections.Generic

Public Module Program
	' ===== PROCEDURE 1: Menampilkan Menu =====
	Public Sub TampilkanMenu()
		Console.WriteLine("========================================")
		Console.WriteLine("   PROGRAM MANAJEMEN DATA MAHASISWA")
		Console.WriteLine("========================================")
		Console.WriteLine("1. Tampilkan Data Mahasiswa")
		Console.WriteLine("2. Cek Status Kelulusan (Percabangan)")
		Console.WriteLine("3. Hitung Rata-rata Nilai (Perulangan)")
		Console.WriteLine("4. Keluar")
		Console.WriteLine("========================================")
		Console.Write("Pilih menu (1-4): ")
	End Sub
	
	' ===== PROCEDURE 2: Membaca File (Simulasi) =====
	Public Function BacaDataMahasiswa() As List(Of String())
		Dim dataMahasiswa As New List(Of String())
		
		' Simulasi pembacaan file
		' Dalam online compiler, kita simulasikan data seperti membaca dari file
		Console.WriteLine(Environment.NewLine & "Membaca data dari file...")
		
		dataMahasiswa.Add(New String() {"Budi Santoso", "85"})
		dataMahasiswa.Add(New String() {"Ani Wijaya", "92"})
		dataMahasiswa.Add(New String() {"Citra Dewi", "67"})
		dataMahasiswa.Add(New String() {"Doni Prasetyo", "78"})
		dataMahasiswa.Add(New String() {"Eka Putri", "45"})
		dataMahasiswa.Add(New String() {"Fajar Rahman", "88"})
		dataMahasiswa.Add(New String() {"Gita Lestari", "73"})
		dataMahasiswa.Add(New String() {"Hendra Kusuma", "56"})
		dataMahasiswa.Add(New String() {"Indah Sari", "91"})
		dataMahasiswa.Add(New String() {"Joko Widodo", "82"})
		
		Console.WriteLine("Data berhasil dibaca!")
		Console.WriteLine("Total mahasiswa: " & dataMahasiswa.Count)
		
		Return dataMahasiswa
	End Function
	
	' ===== PROCEDURE 3: Menampilkan Status dengan Percabangan =====
	Public Sub TampilkanStatusKelulusan(nama As String, nilai As Double)
		Console.WriteLine(Environment.NewLine & "Mahasiswa: " & nama)
		Console.WriteLine("Nilai: " & nilai)
		
		' PERCABANGAN menggunakan If-ElseIf-Else
		If nilai >= 85 Then
			Console.WriteLine("Grade: A")
			Console.WriteLine("Status: LULUS DENGAN PUJIAN")
		ElseIf nilai >= 70 And nilai < 85 Then
			Console.WriteLine("Grade: B")
			Console.WriteLine("Status: LULUS")
		ElseIf nilai >= 60 And nilai < 70 Then
			Console.WriteLine("Grade: C")
			Console.WriteLine("Status: LULUS")
		ElseIf nilai >= 50 And nilai < 60 Then
			Console.WriteLine("Grade: D")
			Console.WriteLine("Status: TIDAK LULUS")
		Else
			Console.WriteLine("Grade: E")
			Console.WriteLine("Status: TIDAK LULUS")
		End If
		Console.WriteLine("----------------------------------------")
	End Sub
	
	' ===== PROCEDURE 4: Hitung Rata-rata dengan Perulangan =====
	Public Function HitungRataRata(dataMahasiswa As List(Of String())) As Double
		Dim total As Double = 0
		Dim count As Integer = 0
		
		' PERULANGAN For
		Console.WriteLine(Environment.NewLine & "Menghitung rata-rata nilai...")
		Console.WriteLine("----------------------------------------")
		
		For i As Integer = 0 To dataMahasiswa.Count - 1
			Dim nilai As Double = Convert.ToDouble(dataMahasiswa(i)(1))
			total += nilai
			count += 1
			Console.WriteLine("Nilai ke-" & count & ": " & nilai)
		Next
		
		Console.WriteLine("----------------------------------------")
		Console.WriteLine("Total nilai: " & total)
		Console.WriteLine("Jumlah mahasiswa: " & count)
		
		If count > 0 Then
			Return total / count
		Else
			Return 0
		End If
	End Function
	
	' ===== PROCEDURE 5: Tampilkan Semua Data dengan Perulangan =====
	Public Sub TampilkanSemuaData(dataMahasiswa As List(Of String()))
		Console.WriteLine(Environment.NewLine & "DAFTAR MAHASISWA")
		Console.WriteLine("========================================")
		Console.WriteLine("No | Nama              | Nilai")
		Console.WriteLine("========================================")
		
		' PERULANGAN For dengan counter
		For i As Integer = 0 To dataMahasiswa.Count - 1
			Dim nama As String = dataMahasiswa(i)(0)
			Dim nilai As String = dataMahasiswa(i)(1)
			Console.WriteLine((i + 1).ToString().PadLeft(2) & " | " & nama.PadRight(17) & " | " & nilai)
		Next
		
		Console.WriteLine("========================================")
	End Sub
	
	' ===== MAIN PROGRAM =====
	Public Sub Main(args() As String)
		Dim pilihan As Integer
		Dim dataMahasiswa As List(Of String()) = Nothing
		Dim lanjut As Boolean = True
		
		Console.WriteLine("========================================")
		Console.WriteLine("SELAMAT DATANG DI PROGRAM VB.NET")
		Console.WriteLine("========================================")
		Console.WriteLine("Program ini mendemonstrasikan:")
		Console.WriteLine("* Pembacaan File (simulasi)")
		Console.WriteLine("* Percabangan (If-ElseIf-Else, Select Case)")
		Console.WriteLine("* Perulangan (For, For Each, While, Do While)")
		Console.WriteLine("* Procedure (Sub dan Function)")
		Console.WriteLine("========================================")
		Console.WriteLine()
		
		' PERULANGAN While untuk menu utama
		While lanjut
			Console.WriteLine()
			TampilkanMenu()
			
			Try
				pilihan = Convert.ToInt32(Console.ReadLine())
				
				' PERCABANGAN Select Case
				Select Case pilihan
					Case 1
						' Menu 1: Baca dan Tampilkan Data
						dataMahasiswa = BacaDataMahasiswa()
						TampilkanSemuaData(dataMahasiswa)
						
					Case 2
						' Menu 2: Tampilkan Status dengan Percabangan
						If dataMahasiswa Is Nothing Then
							Console.WriteLine(Environment.NewLine & "Silakan baca data terlebih dahulu (Menu 1)!")
						Else
							Console.WriteLine(Environment.NewLine & "STATUS KELULUSAN MAHASISWA")
							Console.WriteLine("========================================")
							
							' PERULANGAN Do While
							Dim index As Integer = 0
							Do While index < dataMahasiswa.Count
								Dim nama As String = dataMahasiswa(index)(0)
								Dim nilai As Double = Convert.ToDouble(dataMahasiswa(index)(1))
								TampilkanStatusKelulusan(nama, nilai)
								index += 1
							Loop
						End If
						
					Case 3
						' Menu 3: Hitung Rata-rata dengan Perulangan
						If dataMahasiswa Is Nothing Then
							Console.WriteLine(Environment.NewLine & "Silakan baca data terlebih dahulu (Menu 1)!")
						Else
							Dim rataRata As Double = HitungRataRata(dataMahasiswa)
							Console.WriteLine(Environment.NewLine & "RATA-RATA NILAI: " & Math.Round(rataRata, 2))
							
							' Analisis dengan percabangan
							Console.WriteLine(Environment.NewLine & "Analisis Kelas:")
							If rataRata >= 80 Then
								Console.WriteLine("* Kelas ini SANGAT BAIK! Pertahankan prestasi!")
							ElseIf rataRata >= 70 Then
								Console.WriteLine("* Kelas ini BAIK. Terus tingkatkan!")
							ElseIf rataRata >= 60 Then
								Console.WriteLine("* Kelas ini CUKUP. Perlu bimbingan tambahan.")
							Else
								Console.WriteLine("* Kelas ini perlu PERHATIAN KHUSUS!")
							End If
						End If
						
					Case 4
						' Menu 4: Keluar
						Console.WriteLine(Environment.NewLine & "Terima kasih telah menggunakan program ini!")
						Console.WriteLine("Program selesai.")
						lanjut = False
						
					Case Else
						' Input tidak valid
						Console.WriteLine(Environment.NewLine & "Pilihan tidak valid! Pilih 1-4.")
				End Select
				
			Catch ex As Exception
				Console.WriteLine(Environment.NewLine & "Error: Input tidak valid! " & ex.Message)
			End Try
			
			If lanjut Then
				Console.WriteLine(Environment.NewLine & "----------------------------------------")
			End If
		End While
		
		Console.WriteLine(Environment.NewLine & "=== PROGRAM SELESAI ===")
	End Sub
End Module
