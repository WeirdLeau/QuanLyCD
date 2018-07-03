using System;

public class NhanVien
{
    private string email;
    private string mk;
    private int loaiNV;
	public NhanVien()
	{
        
	}

    public string TenNV { get => email; set => email = value; }
    public string Mk { get => mk; set => mk = value; }
    public int LoaiNV { get => loaiNV; set => loaiNV = value; }
}
