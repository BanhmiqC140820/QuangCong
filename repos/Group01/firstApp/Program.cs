using firstApp.OOP;

/*List<IShape> list = new List<IShape>();
list.Add(new Circle { Radius = 10 });
list.Add(new Rectangle { Height = 10, Width = 20 });
foreach (IShape s in list)
{
    Console.WriteLine("Dien Tich: " + s.Area());
}*/
string[] strings = new string[]
{
    "Hoang","Dung","Nam","Quang","Long","Ly"
};
// DS có 4 kí tự trở lên
// không sử dụng linQ
#region Not LinQ
List<string> result = new List<string>();
/*foreach (string s in strings)
{
    if (s.Length >= 4)
        result.Add(s);
}

foreach (string s in result)
{
    Console.WriteLine(s);
}*/
#endregion
// LinQ
#region LinQ
/*result =strings.Where(t=> t.Length >= 4).ToList();
Console.WriteLine("-------");
result.ForEach(t => Console.WriteLine(t));

result =strings.Where(t  => t.StartsWith("L")).ToList();
Console.WriteLine("-------");
result.ForEach(t => Console.WriteLine(t));

Console.WriteLine("-------");
strings.Where(t => t.StartsWith("L") && t.Length >= 4).ToList().ForEach(t => Console.WriteLine(t));*/
//
#endregion

#region khoi tao data
List<int> Numbers = new List<int>();
Random random = new Random();
for(int i=0; i < 10; i++)
{
    Numbers.Add(random.Next(20));
}
//Numbers.ForEach(number => Console.Write(number + " "));
#endregion

#region Thong ke, Max,min, Average, Sum, Count cua Numbers
Console.WriteLine($"Max = {Numbers.Max()}, Min= {Numbers.Min()}, Sum= {Numbers.Sum()}, Count = {Numbers.Count}, Average = {Numbers.Average()}");
#endregion

#region Thong ke, Max,min, Average, Sum, Count cua so chan
List<int> result_2 = new List<int>();
result_2= Numbers.Where(Number => (Number%2)==0).ToList();
Console.WriteLine($"Max = {result_2.Max()}, Min= {result_2.Min()}, Sum= {result_2.Sum()}, Count = {result_2.Count}, Average = {result_2.Average()}");
#endregion

#region Tạo danh sách sinh viên. Thông kê có bao nhiêu nam, bao nhiêu nữ
var lsSV = SinhVien.GETSV();
Console.WriteLine("---------Male----------");
var lsMale=lsSV.Where(e => e.GENDER==SinhVien.EGENDER.Male).ToList();
lsMale.ForEach(e => Console.WriteLine(e));

Console.WriteLine("---------DOB----------");
int nextMonth = (DateTime.Now.Month + 1) ==13?1 :(DateTime.Now.Month+1);
var lsDOB = lsSV.Where(e => e.DOB.Month==nextMonth).ToList();
lsDOB.ForEach(e => Console.WriteLine(e));
#endregion