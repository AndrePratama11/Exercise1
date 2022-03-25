using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Exercise1
{
    class Program
    {
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=ANDREPRATAMA;database=Exercise1;Integrated Security=TRUE");
                con.Open();

                SqlCommand prd = new SqlCommand("create table Produk (Kode_Produk char(4) primary key," +
                    "Nama_Produk varchar(50), harga char(50), Deskripsi varchar(50), Stok varchar(3))", con);
                prd.ExecuteNonQuery();
                SqlCommand kry = new SqlCommand("create table Karyawan (Id_Karyawan char(4) primary key," +
                   "Nama varchar(50), alamat varchar(50), No_Telp char(12), Jenis_Kelamin char(3))", con);
                kry.ExecuteNonQuery();
                SqlCommand pmb = new SqlCommand("create table Pembeli (Id_Pembeli char(4) primary key," +
                   "Nama varchar(50), alamat varchar(50), No_Telp char(12), Jenis_Kelamin char(1))", con);
                pmb.ExecuteNonQuery();
                SqlCommand trs = new SqlCommand("create table Transaksi (Id_Transaksi char(4) primary key," +
                  "Kode_Produk char(4) foreign key references Produk(Kode_Produk), Id_Karyawan char(4) foreign key references Karyawan(Id_Karyawan), Id_Pembeli char(4) foreign key references Pembeli(Id_Pembeli))", con);
                trs.ExecuteNonQuery();

                Console.WriteLine("Tabel Berhasil Dibuat....");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal Membuat Tabel... " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }

        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=ANDREPRATAMA;database=Exercise1;Integrated Security=TRUE");
                con.Open();

                SqlCommand prd = new SqlCommand("insert into Produk (Kode_Produk, Nama_Produk, harga, Deskripsi, Stok)" +
                    "values('P001','Paracetamol','10000', 'Obat penurun panas', '99')", con);
                prd.ExecuteNonQuery();
                SqlCommand prd2 = new SqlCommand("insert into Produk (Kode_Produk, Nama_Produk, harga, Deskripsi, Stok)" +
                     "values('P002','Paramex','16000', 'Obat sakit kepala', '50')", con);
                prd2.ExecuteNonQuery();
                SqlCommand prd3 = new SqlCommand("insert into Produk (Kode_Produk, Nama_Produk, harga, Deskripsi, Stok)" +
                    "values('P003','Kalpanax','18000', 'Obat Jamur', '23')", con);
                prd3.ExecuteNonQuery();
                SqlCommand prd4 = new SqlCommand("insert into Produk (Kode_Produk, Nama_Produk, harga, Deskripsi, Stok)" +
                    "values('P004','Alleron','9000', 'Obat Gatal', '19')", con);
                prd4.ExecuteNonQuery();
                SqlCommand prd5 = new SqlCommand("insert into Produk (Kode_Produk, Nama_Produk, harga, Deskripsi, Stok)" +
                    "values('P005','Hexadol','20000', 'Obat sakit tenggorokan', '66')", con);
                prd5.ExecuteNonQuery();

                SqlCommand kry = new SqlCommand("insert into Karyawan (Id_Karyawan, Nama, alamat, No_Telp, Jenis_Kelamin)" +
                    "values('K001','Irsyad','Bantul', '081343212212','L')", con);
                kry.ExecuteNonQuery();
                SqlCommand kry2 = new SqlCommand("insert into Karyawan (Id_Karyawan, Nama, alamat, No_Telp, Jenis_Kelamin)" +
                    "values('K002','Andre','Bantul', '082212342343','L')", con);
                kry2.ExecuteNonQuery();
                SqlCommand kry3 = new SqlCommand("insert into Karyawan (Id_Karyawan, Nama, alamat, No_Telp, Jenis_Kelamin)" +
                    "values('K003','Nisya','Kulonprogo', '081354665676','P')", con);
                kry3.ExecuteNonQuery();
                SqlCommand kry4 = new SqlCommand("insert into Karyawan (Id_Karyawan, Nama, alamat, No_Telp, Jenis_Kelamin)" +
                    "values('K004','Samuel','Gamping', '083352617263','L')", con);
                kry4.ExecuteNonQuery();
                SqlCommand kry5 = new SqlCommand("insert into Karyawan (Id_Karyawan, Nama, alamat, No_Telp, Jenis_Kelamin)" +
                    "values('K005','Kayes','Tamantirto', '081123214456','P')", con);
                kry5.ExecuteNonQuery();

                SqlCommand pmb = new SqlCommand("insert into Pembeli (Id_Pembeli, Nama, alamat, No_Telp, Jenis_Kelamin)" +
                    "values('B001','Joan','Gamping', '082232124567','L')", con);
                pmb.ExecuteNonQuery();
                SqlCommand pmb2 = new SqlCommand("insert into Pembeli (Id_Pembeli, Nama, alamat, No_Telp, Jenis_Kelamin)" +
                    "values('B002','Yesi','Gamping', '082278983321','P')", con);
                pmb2.ExecuteNonQuery();
                SqlCommand pmb3 = new SqlCommand("insert into Pembeli (Id_Pembeli, Nama, alamat, No_Telp, Jenis_Kelamin)" +
                     "values('B003','Nina','Bantul', '083425162718','P')", con);
                pmb3.ExecuteNonQuery();
                SqlCommand pmb4 = new SqlCommand("insert into Pembeli (Id_Pembeli, Nama, alamat, No_Telp, Jenis_Kelamin)" +
                    "values('B004', 'Bima','Kaliurang', '084637281928','L')", con);
                SqlCommand pmb5 = new SqlCommand("insert into Pembeli (Id_Pembeli, Nama, alamat, No_Telp, Jenis_Kelamin)" +
                     "values('B005','Sekar','Giwangan', '083566782541','P')", con);
                pmb5.ExecuteNonQuery();

                SqlCommand trs = new SqlCommand("insert into Transaksi (Id_Transaksi, Id_Pembeli, Id_Karyawan, Kode_Produk)" +
                    "values('T001','B002','K005','P001')", con);
                trs.ExecuteNonQuery();
                SqlCommand trs2 = new SqlCommand("insert into Transaksi (Id_Transaksi, Id_Pembeli, Id_Karyawan, Kode_Produk)" +
                    "values('T003','B001','K002','P003')", con);
                trs2.ExecuteNonQuery();
                SqlCommand trs3 = new SqlCommand("insert into Transaksi (Id_Transaksi, Id_Pembeli, Id_Karyawan, Kode_Produk)" +
                    "values('T002','B002','K004','P002')", con);
                trs3.ExecuteNonQuery();
                SqlCommand trs4 = new SqlCommand("insert into Transaksi (Id_Transaksi, Id_Pembeli, Id_Karyawan, Kode_Produk)" +
                    "values('T005','B005','K001','P005')", con);
                trs4.ExecuteNonQuery();
                SqlCommand trs5 = new SqlCommand("insert into Transaksi (Id_Transaksi, Id_Pembeli, Id_Karyawan, Kode_Produk)" +
                    "values('T004','B001','K005','P003')", con);
                trs5.ExecuteNonQuery();

                Console.WriteLine("Data berhasil Di input...");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal Menginput data... " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
        static void Main(string[] args)
        {
            //new Program().CreateTable();
            new Program().InsertData();
        }
    }
}
