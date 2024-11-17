using DataBase;

List<Students> students = new List<Students>()
{
    new Students{ ClassId = 1, StudentName = "Ali", StudentId = 1 },
    new Students{ ClassId = 2, StudentName = "Ayşe", StudentId = 2 },
    new Students{ ClassId = 1, StudentName = "Mehmet", StudentId = 3 },
    new Students{ ClassId = 3, StudentName = "Fatma", StudentId = 4 },
    new Students{ ClassId = 2, StudentName = "Ahmet", StudentId = 5 }
};

List<Classes> classes = new List<Classes>()
{
    new Classes{ ClassId = 1, ClassName = "Matematik"},
    new Classes{ ClassId = 2, ClassName = "Türkçe"},
    new Classes{ ClassId = 3, ClassName = "Kimya"}
};

var groupJoinResult = classes.GroupJoin(
    students, // öğrenciler tablosu
    c => c.ClassId, // sınıflar tablosunu birleştirme anahtarı
    s => s.ClassId, // Öğrenciler tabolasunu birleştirme anahtarı
    (classObj, studentGroup) => new
    {
        ClassName = classObj.ClassName, // sınıf adı
        Students = studentGroup // o sınıfa ait öğrenciler
    }
);

// sonuçları ekrana yazdırma

foreach (var classGroup in groupJoinResult)
{
    Console.WriteLine($"Sınıf: {classGroup.ClassName}");

    //sınıftaki öğrencileri yazdırma
    foreach (var student in classGroup.Students)
    {
        Console.WriteLine($"  - {student.StudentName}");
    }
}
