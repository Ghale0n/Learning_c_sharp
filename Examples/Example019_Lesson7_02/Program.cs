//Директории

string path = "C:/Users/Ghaleon/Desktop/GB/Learning C#/Examples/Example019_Lesson7_02";  
DirectoryInfo di = new DirectoryInfo(path);
Console.WriteLine(di.CreationTime);

FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    Console.WriteLine(fi[i].Name);
}
