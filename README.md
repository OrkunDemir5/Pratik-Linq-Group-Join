# Okul Veritabanı Projesi

Bu proje, bir okulun öğrenci ve sınıf bilgilerini yönetmek için temel bir C# uygulamasıdır. Projede LINQ kullanılarak `GroupJoin` işlemi ile sınıflar ve öğrenciler arasındaki ilişki kurulmuştur. Her sınıfa ait öğrencilerin listelendiği bir çıktı elde edilmiştir.

## **Özellikler**

- **Sınıflar ve Öğrenciler Arasında İlişki**: 
  - Öğrenciler, sınıflarına `ClassId` özelliği aracılığıyla bağlanmıştır.
- **Group Join Kullanımı**:
  - Sınıflar ve öğrenciler `GroupJoin` ile birleştirilerek, her sınıfa ait öğrenciler bir grup altında listelenmiştir.
- **Dinamik Veri Yazdırma**:
  - Sonuçlar her sınıfın adı ve o sınıfa ait öğrencilerin isimleriyle birlikte ekrana yazdırılmıştır.

## **Tablo Yapısı**

### **Öğrenciler (Students)**
| Özellik       | Veri Tipi | Açıklama                     |
|---------------|-----------|-----------------------------|
| StudentId     | `int`     | Öğrencinin benzersiz kimliği |
| StudentName   | `string`  | Öğrencinin adı              |
| ClassId       | `int`     | Öğrencinin ait olduğu sınıfın kimliği |

### **Sınıflar (Classes)**
| Özellik       | Veri Tipi | Açıklama                     |
|---------------|-----------|-----------------------------|
| ClassId       | `int`     | Sınıfın benzersiz kimliği    |
| ClassName     | `string`  | Sınıfın adı                 |

## **Kullanılan Teknolojiler**

- **Programlama Dili**: C#
- **IDE**: Visual Studio
- **LINQ**: Sınıflar ve öğrenciler arasındaki ilişkiyi gruplamak için kullanılmıştır.

