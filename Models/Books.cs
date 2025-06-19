namespace bookstories_.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        // ربط الكتاب بالمؤلف
        public int AuthorId { get; set; }       // مفتاح أجنبي
        public Authors Author { get; set; }     // كائن المؤلف نفسه (اختياري)
    }
}
