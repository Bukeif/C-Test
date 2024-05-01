// See https://aka.ms/new-console-template for more information
// 字串常見的用法
string phrase = "Hello Mr.buke";
// \n 換行
Console.WriteLine("Hello \nMr.buke");

// \" 可以顯示 雙引號
Console.WriteLine("Hello \"Mr.buke \"");

// Length 一樣可以得到字串長度
Console.WriteLine(phrase.Length);

// 指定的變數全部轉換成大寫
Console.WriteLine( phrase.ToUpper() );
// 轉換成小寫
Console.WriteLine(phrase.ToLower());
// 檢查字串內包含誰 
// 有就回傳 true
// 沒有就回傳 fasle
Console.WriteLine( phrase.Contains("pk") );

// 字串也可以用陣列指定方式看該索引位置的文字 
Console.WriteLine( phrase[6] );
// 如果有重複的會回傳重複的
// 指定字串的話，會回傳開頭的位置
// 指定不存在的字，會回傳 -1
Console.WriteLine(phrase.IndexOf('l') );

// 指定位置開始把前面的字切割掉
Console.WriteLine( phrase.Substring(6) );
// 指定開始切割位置，結束切割位置，這樣只會保留中間的字
Console.WriteLine(phrase.Substring(6, 3));



