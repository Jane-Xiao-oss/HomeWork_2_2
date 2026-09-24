// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Formats.Asn1;
using System.Net;
using System.Runtime.CompilerServices;

void EnterData()
{
    Console.WriteLine("指令錯誤，請輸入正確的資訊");
}


// //1.智慧電梯指令模擬器
// bool running = true;
// int floor = 1;
// int move = 1;
// int regularize = 0;

// while (running)
// {
//     Console.Write("goto:N：前往 N 樓。N 必須是 1～10 的整數:  ");
//     string[] input = (Console.ReadLine() ?? "").Trim().ToLower().Split(":");
//     string instruction = input[0];

//     if (instruction == "goto")
//     {
//         if(int.TryParse(input[1], out floor) )
//         {
//             if(move > 5)
//             {
//                 Console.WriteLine("今日移動次數已滿");
//                 continue;
//             }
//             if(floor == regularize)
//             {
//                 Console.WriteLine("已在該樓層");
//             }
//             else if(floor >= 1  && floor <= 10)
//             {
//                 Console.WriteLine($"已到達{floor}樓");
//                 regularize = floor ;
//                 move++;
//             }
//             else
//             {
//                 Console.WriteLine("樓層超出範圍");
//             }
//         }
//         else
//         {
//             EnterData();
//         }
//     }    
//     else if (instruction == "status")
//     {
//         Console.WriteLine($"目前樓層：{floor}，移動次數:{move-1}");
//     }
//     else if (instruction == "exit")
//     {
//         Console.WriteLine("程式結束");
//         break;
//     }
//     else
//     {
//         EnterData();
//     }
// }

// //2.補考資格審核系統
// bool running1= true;
// decimal score = 0;

// while (running1)
// {
//     Console.Write("輸入一位學生資料，格式固定為：出席率,期中考,期末考,作業平均(四個欄位都必須是 0～100 的整數):  ");
//     string[] input = (Console.ReadLine() ?? "").Trim().Split(',');
    
    
//     if(int.TryParse(input[0],out int attendance) && int.TryParse(input[1],out int midterm) && int.TryParse(input[2],out int final) && int.TryParse(input[3],out int Operation) && attendance >= 0 && attendance <= 100)
//     {
//         if (attendance < 60)
//         {
//             Console.WriteLine("結果：不得補考");
//             return;
//         }
//         if(midterm >= 60 && final >= 60)
//         {
//             Console.WriteLine("結果：直接及格");
//             return;
//         }

//         score = PositiveInteger(midterm, final, Operation);
        
//         if(score >= 60)
//         {
//             Console.WriteLine("結果：及格");
//         }
//         else if(score < 60 && score >=50 && Operation >= 70)
//         {
//             Console.WriteLine("結果：可補考");
//         }
//         else if(score > -1)
//         {
//             Console.WriteLine($"結果：不及格");
//         }
//         return;
//     }
//     EnterData();
// }


// decimal PositiveInteger(decimal midterm, decimal final, decimal Operation)
// {
//     if( midterm >= 0 && midterm <= 100 && final >= 0 && final <= 100 && Operation >= 0 && Operation <= 100)
//     {
//         score = (midterm * 0.3m) + (final * 0.4m) + (Operation * 0.3m);
//         Console.WriteLine($"學期成績：{score:F1}");
//         return score;
//     }
//     else
//     {
//         return -1;
//     }
// }


//3.自助洗衣機狀態控制
// bool running2 = true;
// string statusing = "idle";
// int frequency = 1;


// while (running2)
// {
    
//     Console.Write("請輸入項目:");
//     string[] input = (Console.ReadLine() ?? "").Trim().ToLower().Split(':');
//     string item = input[0];

//     if(item == "exit")
//     {
//         Console.WriteLine("程式結束");
//         return;
//     }
//     if(item == "finish" && statusing =="washing")
//     {
//         statusing = "idle";
//         Console.WriteLine("洗衣完成");
//         continue;
//     }
//     else if(item == "finish" && statusing == "idle")
//     {
//         Console.WriteLine("目前沒有進行中的洗衣");
//         continue;
//     }
    
//     if(item == "wash" )
//     {
//         if(statusing == "washing")
//         {
//             Console.WriteLine($"目前已有進行中的洗衣");
//             continue;
//         }

//         if(frequency > 3)
//         {
//             Console.WriteLine("今日洗衣次數已滿");
//             continue;
//         }

//         if(input.Length >= 2 && int.TryParse(input[1], out int minute) && statusing ==  "idle" && minute >= 10 && minute <= 60)
//         {
//             frequency++;
//             statusing = "washing";
//             Console.WriteLine($"開始洗衣:{minute}分鐘");
//             continue;
//         }
//         Console.WriteLine("時間格式錯誤"); 

//     }
//     else if(item == "status")
//     {
//         Console.WriteLine($"目前狀態：{statusing}");
//         continue;
//     }
//     else if(item == "cancel" && statusing == "washing")
//     {
//         statusing = "idle";
//         Console.WriteLine($"已取消洗衣");
//         continue;
//     }
//     else if(item == "cancel" && statusing == "idle")
//     {
//         statusing = "idle";
//         Console.WriteLine($"沒有可取消的程序");
//         continue;
//     }
//     EnterData();

// }


// //4.闖關積分與連勝獎勵
// bool running3 = true;
// int fraction = 0;
// int continuous = 0;

// Console.WriteLine($"初始分數{fraction}，連勝{continuous}次");

// while (running3)
// {
//     Console.Write("輸入 win、lose、bonus:N、status、exit:");
//     string[] input = (Console.ReadLine() ?? "").Trim().ToLower().Split(':');
//     string options = input[0];

//     if(options == "exit")
//     {
//         Console.WriteLine("程式結束");
//         return;
//     }
//     else if(options == "status")
//     {
//         Console.WriteLine($"分數:{fraction}，連勝:{continuous}次");
//         continue;
//     }
//     else if(options == "win")
//     {
//         fraction = fraction + 10;
//         continuous++;
        
//         if(continuous %3 == 0)
//         {
//             fraction = fraction + 20;
//             Console.WriteLine($"獲勝，觸發連勝獎勵，分數:{fraction}");
//             continue;
//         }

//         Console.WriteLine($"獲勝，分數:{fraction}");
//         continue;
//     }
//     else if (options == "lose")
//     {
//         fraction = fraction - 5;
//         continuous = 0;

//         if(fraction <= 0 )
//         {
//             fraction = 0;
//         }
//         Console.WriteLine($"失敗，分數:{fraction}");
//         continue;
//     }
//     else if (options == "bonus")
//     {
//         if(int.TryParse(input[1], out int integer) && integer <= 50 && integer >= 1)
//         {
//             fraction = fraction + integer;
//             Console.WriteLine($"獎勵加分，分數:{fraction}");
//             continue;
//         }
//     }
//     EnterData();
// }


// //5.設備租借與逾期計費
// bool running4 = true;
// string statusing = "available";
// int day = 0;
// decimal total = 0;
// string name="";

// while (running4)
// {
//     Console.Write("支援rent:姓名、return:天數、status、exit:");
//     string[] input = (Console.ReadLine() ?? "").Trim().Split(':');
//     string options = input[0];
    
//     if(options == "exit")
//     {
//         Console.WriteLine("程式結束");
//         return;
//     }
//     else if (options == "rent")
//     {
        
//         if (input[1].Length > 2 && statusing == "available")
//         {
//             name = input[1];
//             Console.WriteLine($"租借成功:{name}");
//             statusing = "rented";
//             continue;
//         }
//         else if(statusing != "available")
//         {
//             Console.WriteLine($"租借中:{name}");
//             continue;
//         }
//         Console.WriteLine("姓名格式錯誤");
//         continue;
//     }
//     else if(options == "status")
//     {
//         if (statusing == "available")
//         {
//             Console.WriteLine("設備可租借");
//             continue;
//         }
//         Console.WriteLine($"租借中:{name}");
//         continue;
//     }
//     else if(options == "return")
//     {
//         if(int.TryParse(input[1], out day) && day > 0 && statusing == "rented")
//         {
//             total = RentalFee (day);
//             Console.WriteLine($"歸還成功，總費用:{total}");
//             statusing = "available";
//             continue;
//         }
//         else if(statusing != "rented")
//         {
//             Console.WriteLine("目前沒有租借中的設備");
//             continue;
//         }
//         Console.WriteLine("天數格式錯誤");
//         continue;
//     }
//     EnterData();
// } 

// decimal RentalFee (int day)
// {
//     if(day <= 3)
//     {
//         return day * 100m;
//     }
//     else if (day >= 4 && day <= 7)
//     {
//         return (3*100m) + (day -3) * 80m;
//     }
//     else if(day >= 8 && day <= 10)
//     {
//         return (3 * 100m) + (4 * 80m) + (day - 7) * 50m;
//     }
//     else
//     {
//         return (3 * 100m) + (4 * 80m) + (3* 50m) + (day - 10)* 50m + 300m;
//     }
// }

// //6.電影院座位預約控制
// bool running5 = true;
// int seat = 0;
// int cancel = 0;
// int reserve = 0;

// while (running5)
// {
//     Console.Write("輸入reserve:N、cancel:N、status、close:");
//     string[] input =(Console.ReadLine() ?? "").Trim().ToLower().Split(':');
//     string options = input[0];

//     if(options == "close")
//     {
//         if(seat >= 12)
//         {
//             Console.WriteLine("本場已滿");
//             return;
//         }
//         Console.WriteLine($"剩餘空位:{12-seat}");
//         return;
//     }
//     else if(options == "status")
//     {
//         Console.WriteLine($"已預約:{seat}，剩餘:{12-seat}");
//         continue;
//     }
//     else if (options == "cancel")
//     {
//         if(int.TryParse(input[1], out cancel) && cancel > 0 )
//         {
            
//             if(cancel > seat)
//             {
//                 Console.WriteLine("取消數量超過已預約數");
//                 continue;
//             }

//             seat = seat - cancel;
//             Console.WriteLine($"取消成功，已預約:{seat}");
//             continue;
//         }
//     }
//     else if (options == "reserve")
//     {
//         if(int.TryParse(input[1], out reserve) && reserve > 0 )
//         {
            
//             if(seat + reserve > 12)
//             {
//                 Console.WriteLine("座位不足");
//                 continue;
//             }

//             seat = seat + reserve;
//             Console.WriteLine($"預約成功，已預約:{seat}");
//             continue;
//         }
//     }
//     EnterData();
// }



// //7.物流運費規則引擎
// decimal cost =260m;
// decimal remote = 0m;
// decimal yes = 0m;
// decimal total = 0m;

// Console.Write("輸入格式(重量公斤,地區,急件，例如 6.5,remote,yes):   ");
// string[] input = (Console.ReadLine() ?? "").Trim().ToLower().Split(',');
// string area = input[1].Trim().ToLower();
// string urgent = input[2].Trim().ToLower();

// if(double.TryParse(input[0], out double weight))
// {
//     if(weight > 30)
//     {
//         EnterData();
//         return;
//     }
//     else if(weight <= 5)
//     {
//         cost = 80m;
//     }
//     else if(weight > 5 && weight <= 10)
//     {
//         cost = 120m;
//     }        
//     else if(weight > 10 && weight <= 20)
//     {
//         cost = 180m;
//     }
// }
    
// if(area == "remote" || area == "city" )
// {
//     if(area == "remote")
//     {
//         remote = 70m;
//     }
// }
// else
// {
//     EnterData();
//     return;
// }

// if(urgent == "yes" || urgent == "no")
// {
//     if(urgent == "yes")
//     {
//         yes = 100m;
//     }
// }
// else
// {
//     EnterData();
//     return;
// }

// total = cost + remote + yes;
// Console.WriteLine($"基本運費:{cost}");
// Console.WriteLine($"偏遠加價:{remote}");
// Console.WriteLine($"急件加價:{yes}");
// Console.WriteLine($"應付運費:{total}");


// //8. 交通號誌狀態機
// bool running7 = true;
// string signal = "green";
// string urgent = "off";


// while (running7)
// {
//     Console.Write("輸入格式(支援 next、emergency:on、emergency:off、status、exit):   ");
//     string[] input = (Console.ReadLine() ?? "").Trim().ToLower().Split(':');
//     string options = input[0];

//     if(options == "exit")
//     {
//         Console.WriteLine("程式結束");
//         return;
//     }
//     else if(options == "status")
//     {
//         Console.WriteLine($"目前號誌:{signal}");
//         continue;
//     }
//     else if (options == "next")
//     {
//         if(urgent == "on")
//         {
//             Console.WriteLine("緊急模式中");
//             continue;
//         }

//         if(signal == "red")
//         {
//             signal = "green";
//         }
//         else if(signal == "yellow")
//         {
//             signal = "red";
//         }
//         else if(signal == "green")
//         {
//             signal = "yellow";
//         }
//         if(urgent == "on")
//         {
//             Console.WriteLine("緊急模式");
//             continue;
//         }
//         Console.WriteLine($"號誌:{signal}");
//         continue;
//     }
//     else if(options == "emergency")
//     {
//         string emergency = input[1].Trim().ToLower();
//         if(emergency == "on" || emergency == "off")
//         {
//             if(emergency == "on")
//             {
//                 if(urgent == "on")
//                 {
//                     Console.WriteLine("已在緊急模式");
//                     continue;
//                 }
//                 urgent = "on";
//                 signal = "red";
//                 Console.WriteLine($"已進入緊急模式，號誌:{signal}");
//                 continue;
//             }

//             if(urgent == "off")
//                 {
//                     Console.WriteLine("目前非緊急模式");
//                     continue;
//                 }
            
//             urgent = "off";
//             Console.WriteLine("已解除緊急模式");
//             continue;
//         }
//     }
//     EnterData();
// }


// //9.販賣機餘額與庫存系統
// bool running8 = true;
// decimal balance = 0m;
// int inventoryA = 2;
// int inventoryB = 1;
// int inventoryC = 2;
// decimal price = 0m;
// string commodity = "";


// while (running8)
// {
//     Console.Write("支援coin:N、buy:X、status、refund、exit:");
//     string[] input = (Console.ReadLine() ?? "").Split(':');
//     string options = input[0].ToLower().Trim();

//     switch (commodity)
//     {
//         case "A":
//         price = 35m;
//         break;
//         case "B":
//         price = 50m;
//         break;
//         case "C":
//         price = 70m;
//         break;
//     }

//     if (options == "exit")
//     {
//         if(balance > 0)
//         {
//             Console.WriteLine($"退幣:{balance}元");
//         }
//         Console.WriteLine("程式結束");
//         return;
//     }
//     else if(options == "refund")
//     {
//         Console.WriteLine($"退回餘額:{balance}元");
//         balance = 0;
//         continue;
//     }
//     else if(options == "status")
//     {
//         Console.WriteLine($"餘額:{balance}，A:{inventoryA}，B:{inventoryB}，C:{inventoryC}");
//         continue;
//     }
//     else if(options == "buy")
//     {
//         commodity = input[1].Trim().ToUpper();
                
//         // if(balance < price)
//         // {
//         //     Console.WriteLine("餘額不足");
//         //     continue;
//         // }
//         if(commodity == "A")
//         {
            
//             if(inventoryA <= 0 )
//             {
//                 Console.WriteLine($"{commodity} 已售完");
//                 continue;
//             }
//             else if(balance < price)
//             {
//                 Console.WriteLine("餘額不足");
//                 continue;
//             }
//             inventoryA = inventoryA - 1;
//             balance = balance - 35m;
//             Console.WriteLine($"成功購買 A，餘額:{balance}元");
//             continue;
//         }
//         else if(commodity == "B")
//         {

//             if(inventoryB <= 0 )
//             {
//                 Console.WriteLine($"{commodity} 已售完");
//                 continue;
//             }
//             else if(balance < price)
//             {
//                 Console.WriteLine("餘額不足");
//                 continue;
//             }
//             inventoryB = inventoryB - 1;
//             balance = balance - 50m;
//             Console.WriteLine($"成功購買 B，餘額:{balance}元");
//             continue;
//         }
//         else if(commodity == "C")
//         {

//             if(inventoryC <= 0 )
//             {
//                 Console.WriteLine($"{commodity} 已售完");
//                 continue;
//             }
// else      if(balance < price)
//             {
//                 Console.WriteLine("餘額不足");
//                 continue;
//             }
//             inventoryC = inventoryC - 1;
//             balance = balance - 70m;
//             Console.WriteLine($"成功購買 C，餘額:{balance}元");
//             continue;
//         }
//     }
//     else if(options == "coin")
//     {
//         if(decimal.TryParse(input[1],out decimal money) || money == 50 || money == 20 || money == 10)
//         {
//             balance = balance + money;
//             Console.WriteLine($"成功投入 {money}元，餘額:{balance}元");
//             continue;
//         }
//         Console.WriteLine("不接受此硬幣");
//         continue;
//     }

//     EnterData();
// }


//10.停車場容量與保留車位
bool running9 = true;
int quantity = 1;
int remain = 8;
int vip = 1;
int normal = 1;
string vehicle ="";

while (running9)
{
    Console.Write("支援in:normal、in:vip、out:normal、out:vip、status、close:");
    string[] input = (Console.ReadLine() ?? "").Trim().ToLower().Split(':');
    string options = input[0];

    if(options == "close")
    {
        Console.WriteLine($"normal:{normal}，vip:{vip}，總車數:{quantity}，剩餘:{remain}");
        Console.WriteLine("程式結束");
        return;
    }
    else if(options == "status")
    {
        Console.WriteLine($"normal:{normal}，vip:{vip}，總車數:{quantity}，剩餘:{remain}");
        continue;
    }
    else if (options == "out")
    {
        vehicle = input[1].Trim().ToLower();

        if(vehicle == "normal" && normal > 0)
        {
            normal--;
            quantity--;
            remain++;
            Console.WriteLine("一般車離場");
            continue;
        }
        else if(vehicle == "vip" && vip > 0)
        {
            vip--;
            quantity--;
            remain++;
            Console.WriteLine("VIP車離場");
            continue;
        }
        Console.WriteLine("無此類車輛可離場");
        continue;
    }
    else if (options == "in")
    {
        vehicle = input[1].Trim().ToLower();

        if(quantity > 8)
        {
            Console.WriteLine("停車場已滿");
            continue;
        }
        
        if(vehicle == "normal")
        {
            if(normal > 6 )
            {
                Console.WriteLine("一般車位已滿");
                continue;
            }
            normal++;
            quantity++; 
            remain--;          
            Console.WriteLine("一般車進場");
            continue;
        }
        else if(vehicle == "vip")
        {
            if(vip > 8 || remain == 0)
            {
                Console.WriteLine("VIP車位已滿");
                continue;
            }
            vip++;
            quantity++;
            remain--;  
            Console.WriteLine("VIP車進場");
            continue;
        }
        Console.WriteLine("無此類車輛可離場");
        continue;
    }

EnterData();
}
