using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Nhập nội dung từ người dùng
        Console.WriteLine("Nhập nội dung:");
        string content = Console.ReadLine();

        // Nhập tên file từ người dùng
        Console.WriteLine("Nhập tên file:");
        string fileName = Console.ReadLine();

        // Ghi nội dung vào file
        GhiNoiDungVaoFile(fileName, content);

        // Đọc nội dung từ file và hiển thị lên màn hình
        string noiDungTuFile = DocNoiDungTuFile(fileName);
        Console.WriteLine($"Nội dung từ file '{fileName}':");
        Console.WriteLine(noiDungTuFile);
    }

    static void GhiNoiDungVaoFile(string tenFile, string noiDung)
    {
        try
        {
            // Ghi nội dung vào file
            File.WriteAllText(tenFile, noiDung);
            Console.WriteLine($"Đã ghi nội dung vào file '{tenFile}'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi khi ghi vào file: {ex.Message}");
        }
    }

    static string DocNoiDungTuFile(string tenFile)
    {
        try
        {
            // Đọc nội dung từ file
            string noiDung = File.ReadAllText(tenFile);
            return noiDung;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Lỗi khi đọc từ file: {ex.Message}");
            return null;
        }
    }
}
