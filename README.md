# 📚 Program Manajemen Data Mahasiswa - Visual Basic .NET

![VB.NET](https://img.shields.io/badge/VB.NET-512BD4?style=for-the-badge&logo=.net&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-green.svg?style=for-the-badge)
![Status](https://img.shields.io/badge/Status-Active-success?style=for-the-badge)

Program console interaktif yang dibuat dengan Visual Basic .NET untuk mendemonstrasikan konsep-konsep dasar pemrograman terstruktur.

## 📋 Deskripsi

Program ini adalah aplikasi manajemen data mahasiswa yang menampilkan implementasi lengkap dari:
- ✅ **Pembacaan File** (File Reading)
- ✅ **Percabangan** (Branching/Conditional Statements)
- ✅ **Perulangan** (Looping/Iteration)
- ✅ **Procedure** (Functions & Subroutines)

Program ini cocok untuk pembelajaran pemrograman VB.NET tingkat pemula hingga menengah.

## 🎯 Fitur Utama

### 1. 📂 Pembacaan File (Simulasi)
- Mensimulasikan pembacaan data mahasiswa dari file
- Data disimpan dalam struktur List(Of String())
- Compatible dengan online compiler (tidak perlu file eksternal)

### 2. 🔀 Percabangan (Branching)
Program menggunakan **2 jenis percabangan**:

#### a) If-ElseIf-Else
```vb
If nilai >= 85 Then
    Console.WriteLine("Grade: A - LULUS DENGAN PUJIAN")
ElseIf nilai >= 70 Then
    Console.WriteLine("Grade: B - LULUS")
' ... dan seterusnya
```

#### b) Select Case
```vb
Select Case pilihan
    Case 1
        ' Tampilkan data
    Case 2
        ' Cek status kelulusan
    ' ... dan seterusnya
End Select
```

### 3. 🔄 Perulangan (Looping)
Program menggunakan **3 jenis perulangan**:

#### a) While Loop
```vb
While lanjut
    TampilkanMenu()
    ' Proses menu
End While
```

#### b) For Loop
```vb
For i As Integer = 0 To dataMahasiswa.Count - 1
    ' Proses data
Next
```

#### c) Do While Loop
```vb
Do While index < dataMahasiswa.Count
    ' Proses data
    index += 1
Loop
```

### 4. 🔧 Procedure
Program memiliki **5 Procedure/Function**:

| Procedure | Tipe | Fungsi |
|-----------|------|--------|
| `TampilkanMenu()` | Sub | Menampilkan menu utama |
| `BacaDataMahasiswa()` | Function | Membaca/simulasi data file |
| `TampilkanStatusKelulusan()` | Sub | Menampilkan status dengan percabangan |
| `HitungRataRata()` | Function | Menghitung rata-rata dengan perulangan |
| `TampilkanSemuaData()` | Sub | Menampilkan semua data dengan perulangan |

## 🚀 Cara Menjalankan

### Opsi 1: Online Compiler (Recommended)

1. Buka salah satu online compiler berikut:
   - [JDoodle VB.NET Compiler](https://www.jdoodle.com/compile-vb-net-online)
   - [.NET Fiddle](https://dotnetfiddle.net/)
   - [OneCompiler VB.NET](https://onecompiler.com/vb)

2. Copy seluruh kode dari file `Program.vb`

3. Paste ke online compiler

4. Klik tombol **Run** atau **Execute**

5. Ikuti menu interaktif yang muncul

### Opsi 2: Visual Studio

1. Install [Visual Studio](https://visualstudio.microsoft.com/) dengan .NET Framework

2. Buat New Project → **Console App (.NET Framework)**

3. Pilih **Visual Basic** sebagai bahasa

4. Copy paste kode dari `Program.vb`

5. Tekan **F5** atau klik **Start** untuk menjalankan

### Opsi 3: Command Line (dengan .NET SDK)

```bash
# Compile
vbnc Program.vb

# Run
mono Program.exe
```

## 📖 Cara Menggunakan Program

### Menu Utama

```
========================================
   PROGRAM MANAJEMEN DATA MAHASISWA
========================================
1. Tampilkan Data Mahasiswa
2. Cek Status Kelulusan (Percabangan)
3. Hitung Rata-rata Nilai (Perulangan)
4. Keluar
========================================
```

### Menu 1: Tampilkan Data Mahasiswa
- Membaca data mahasiswa (10 data simulasi)
- Menampilkan dalam format tabel terstruktur
- **Teknologi**: Perulangan For, List manipulation

**Output:**
```
No | Nama              | Nilai
========================================
 1 | Budi Santoso      | 85
 2 | Ani Wijaya        | 92
 3 | Citra Dewi        | 67
...
```

### Menu 2: Cek Status Kelulusan
- Menampilkan status kelulusan setiap mahasiswa
- Sistem grading berdasarkan nilai
- **Teknologi**: Percabangan If-ElseIf-Else, Perulangan Do While

**Kriteria Kelulusan:**
| Grade | Rentang Nilai | Status |
|-------|---------------|--------|
| A | ≥ 85 | Lulus Dengan Pujian |
| B | 70 - 84 | Lulus |
| C | 60 - 69 | Lulus |
| D | 50 - 59 | Tidak Lulus |
| E | < 50 | Tidak Lulus |

### Menu 3: Hitung Rata-rata Nilai
- Menghitung rata-rata nilai kelas
- Menampilkan detail perhitungan
- Memberikan analisis performa kelas
- **Teknologi**: Perulangan For, Mathematical operations

**Output:**
```
Menghitung rata-rata nilai...
----------------------------------------
Nilai ke-1: 85
Nilai ke-2: 92
...
----------------------------------------
RATA-RATA NILAI: 77.3

Analisis Kelas:
* Kelas ini BAIK. Terus tingkatkan!
```

### Menu 4: Keluar
- Mengakhiri program dengan aman

## 📊 Data Mahasiswa (Simulasi)

Program mensimulasikan data dari 10 mahasiswa:

| No | Nama | Nilai | Grade | Status |
|----|------|-------|-------|--------|
| 1 | Budi Santoso | 85 | A | Lulus Dengan Pujian |
| 2 | Ani Wijaya | 92 | A | Lulus Dengan Pujian |
| 3 | Citra Dewi | 67 | C | Lulus |
| 4 | Doni Prasetyo | 78 | B | Lulus |
| 5 | Eka Putri | 45 | E | Tidak Lulus |
| 6 | Fajar Rahman | 88 | A | Lulus Dengan Pujian |
| 7 | Gita Lestari | 73 | B | Lulus |
| 8 | Hendra Kusuma | 56 | D | Tidak Lulus |
| 9 | Indah Sari | 91 | A | Lulus Dengan Pujian |
| 10 | Joko Widodo | 82 | B | Lulus |

**Rata-rata Kelas:** 77.3

## 🏗️ Struktur Kode

```
Program.vb
│
├── Module Program
│   │
│   ├── Sub TampilkanMenu()
│   │   └── Menampilkan menu utama
│   │
│   ├── Function BacaDataMahasiswa() As List(Of String())
│   │   └── Simulasi pembacaan file
│   │       └── Returns: List data mahasiswa
│   │
│   ├── Sub TampilkanStatusKelulusan(nama, nilai)
│   │   ├── Input: nama (String), nilai (Double)
│   │   └── Percabangan If-ElseIf-Else untuk grading
│   │
│   ├── Function HitungRataRata(dataMahasiswa) As Double
│   │   ├── Input: dataMahasiswa (List)
│   │   ├── Perulangan For untuk iterasi
│   │   └── Returns: rata-rata nilai (Double)
│   │
│   ├── Sub TampilkanSemuaData(dataMahasiswa)
│   │   ├── Input: dataMahasiswa (List)
│   │   └── Perulangan For untuk display
│   │
│   └── Sub Main(args() As String)
│       ├── Perulangan While untuk menu loop
│       ├── Percabangan Select Case untuk menu handling
│       ├── Perulangan Do While (di Case 2)
│       └── Try-Catch untuk error handling
```

## 🔧 Teknologi & Konsep

### Bahasa & Framework
- **Bahasa**: Visual Basic .NET
- **Framework**: .NET Framework / Mono
- **Paradigma**: Procedural Programming

### Konsep Pemrograman yang Diimplementasikan

#### 1. Data Structures
- `List(Of String())` untuk menyimpan data mahasiswa
- Array multidimensi untuk nama dan nilai

#### 2. Control Flow
- **Sequential**: Eksekusi berurutan
- **Selection**: If-Else, Select Case
- **Iteration**: While, For, Do While

#### 3. Modular Programming
- Pemisahan fungsi ke dalam procedures
- Reusable code components
- Clean code architecture

#### 4. Error Handling
- Try-Catch blocks
- Input validation
- Graceful error messages

## 📚 Konsep Pembelajaran

Program ini cocok untuk mempelajari:

### Level Pemula
- ✅ Sintaks dasar VB.NET
- ✅ Variabel dan tipe data
- ✅ Input/Output console
- ✅ Percabangan sederhana

### Level Menengah
- ✅ Procedure (Sub & Function)
- ✅ Parameter passing
- ✅ Return values
- ✅ Collections (List)
- ✅ Error handling
- ✅ Program flow control

### Konsep Advanced (Implisit)
- ✅ Modular design
- ✅ Code organization
- ✅ User experience design
- ✅ Data validation

## 🎓 Kesesuaian dengan Kurikulum

Program ini memenuhi kriteria pembelajaran:

| Kriteria | Status | Implementasi |
|----------|--------|--------------|
| Membaca File | ✅ | Function `BacaDataMahasiswa()` |
| Percabangan | ✅ | If-ElseIf-Else, Select Case |
| Perulangan | ✅ | While, For, Do While |
| Procedure | ✅ | 5 Sub/Function berbeda |
| Error Handling | ✅ | Try-Catch blocks |
| User Interface | ✅ | Menu interaktif |

## 🔍 Contoh Penggunaan

### Scenario 1: Cek Data Mahasiswa
```
Input: Pilih menu 1
Output: 
- Data 10 mahasiswa ditampilkan
- Tabel terstruktur dengan No, Nama, Nilai
```

### Scenario 2: Analisis Kelulusan
```
Input: Pilih menu 2
Process:
- Iterasi setiap mahasiswa
- Evaluasi nilai dengan percabangan
- Tentukan grade dan status
Output:
- Status kelulusan setiap mahasiswa
- Grade A/B/C/D/E
```

### Scenario 3: Perhitungan Statistik
```
Input: Pilih menu 3
Process:
- Iterasi dan akumulasi nilai
- Hitung rata-rata
- Analisis performa kelas
Output:
- Rata-rata nilai: 77.3
- Analisis: "Kelas ini BAIK"
```

## 🐛 Troubleshooting

### Error: Namespace conflict
**Problem**: Variable `data` conflicts with `System.Data`
**Solution**: Gunakan nama variable lain seperti `item` atau `mahasiswa`

### Error: vbNewLine not found
**Problem**: `vbNewLine` tidak tersedia di Mono
**Solution**: Gunakan `Environment.NewLine`

### Error: Console.Clear() not supported
**Problem**: Beberapa online compiler tidak support `Console.Clear()`
**Solution**: Hapus atau comment out baris tersebut

### Error: For Each not working
**Problem**: Mono VB compiler versi lama tidak support `For Each` dengan baik
**Solution**: Gunakan `For` loop standar dengan index

## 🤝 Kontribusi

Kontribusi sangat diterima! Berikut cara berkontribusi:

1. Fork repository ini
2. Buat branch fitur baru (`git checkout -b feature/AmazingFeature`)
3. Commit perubahan (`git commit -m 'Add some AmazingFeature'`)
4. Push ke branch (`git push origin feature/AmazingFeature`)
5. Buat Pull Request

### Ide Pengembangan
- [ ] Tambahkan fitur export data ke file
- [ ] Implementasi file reading yang sebenarnya
- [ ] Tambahkan fitur CRUD (Create, Read, Update, Delete)
- [ ] Implementasi database connection
- [ ] Tambahkan fitur sorting dan filtering
- [ ] Buat GUI dengan Windows Forms
- [ ] Tambahkan unit testing

## 📄 Lisensi

Project ini menggunakan lisensi MIT. Lihat file `LICENSE` untuk detail lengkap.

```
MIT License

Copyright (c) 2026 Program Manajemen Data Mahasiswa

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

## 👨‍💻 Author

Program ini dibuat untuk keperluan pembelajaran Visual Basic .NET dan pemrograman terstruktur.

## 📞 Kontak & Support

- **Issues**: Laporkan bug atau request fitur di [GitHub Issues](../../issues)
- **Discussions**: Diskusi dan tanya jawab di [GitHub Discussions](../../discussions)
- **Email**: [contact@example.com](mailto:contact@example.com)

## 🌟 Acknowledgments

- Terima kasih kepada komunitas .NET Indonesia
- Microsoft Documentation untuk referensi VB.NET
- Online compiler providers (JDoodle, .NET Fiddle)
- Seluruh kontributor yang telah membantu pengembangan project ini

## 📈 Project Stats

![GitHub stars](https://img.shields.io/github/stars/yourusername/vbnet-mahasiswa?style=social)
![GitHub forks](https://img.shields.io/github/forks/yourusername/vbnet-mahasiswa?style=social)
![GitHub watchers](https://img.shields.io/github/watchers/yourusername/vbnet-mahasiswa?style=social)

---

**⭐ Jika project ini membantu Anda, jangan lupa berikan star!**

**Made with ❤️ using Visual Basic .NET**
