namespace VoLong_API.Commons
{
    public static class SinhVienHelper
    {
        // Có thể dùng cho nhiều đối tượng và dùng được trong nhiều trường hợp

        // static: là 1 lớp tĩnh không cần khởi tạo, có thể gọi được luôn
        // nếu bên ngoài là static bên trong cũng phải là static
        public static int GetTotalCountOfList<T>(List<T> list)
        {
            return list.Count();
        }
    }
}
