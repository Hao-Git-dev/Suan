// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System.Net;

Console.WriteLine("Hello, World!");
//string encodedUrl = "gmt_create=2023-07-06+10%3A24%3A50&charset=UTF-8&seller_email=developer1%40atombits.cn&subject=%E6%B5%8B%E8%AF%95%E4%BC%9A%E5%91%98&sign=deojM6DDu7UtT4CB3wr5trvSSEgDzGQaMI2uRFsEBa7%2B6X5Bt8H3AkrabEimmxPKvIZRuUnuUK3d%2FLb2Wzf2bQ%2BWeT58ExJPSxm%2FKla3gaQrs%2FaoN4QEA4DAmLdsgR2j1N44dWXY8WEFxLgoAgb2JJAnpSBxdKBFhG4pxXyMyi6nejI5uhtesY4R7WFJdqfSYlXe2Bhwt8dkQmCQ6yLC4aA7rqyRetd1Kv70ceLPLCAmQ0aizInhqsB5AS%2FsuQmFONGx2iVstowZY%2B5LtXYvpwxzU7BQcnrzigBvGkHUDzOHIjMWKLcbp0m2uxRe3W3bU820Q2YSzSE02fo6JtSn%2FQ%3D%3D&buyer_id=2088532210434327&invoice_amount=0.01&notify_id=2023070601222102451034321452749628&fund_bill_list=%5B%7B%22amount%22%3A%220.01%22%2C%22fundChannel%22%3A%22ALIPAYACCOUNT%22%7D%5D&notify_type=trade_status_sync&trade_status=TRADE_SUCCESS&receipt_amount=0.01&app_id=2021004100619249&buyer_pay_amount=0.01&sign_type=RSA2&seller_id=2088641367241774&gmt_payment=2023-07-06+10%3A24%3A50&notify_time=2023-07-06+10%3A24%3A51&version=1.0&out_trade_no=20230706102437_1_%E6%B5%8B%E8%AF%95&total_amount=0.01&trade_no=2023070622001434321426379377&auth_app_id=2021004100619249&buyer_logon_id=133****8778&point_amount=0.00";

//string decodedUrl = WebUtility.UrlDecode(encodedUrl);

//Console.WriteLine(decodedUrl);
//Console.WriteLine("------------------------------------------------------------------------------");
//string str = "gmt_create=2023-07-06 10:24:50&charset=UTF-8&seller_email=developer1@atombits.cn&subject=测试会员&sign=deojM6DDu7UtT4CB3wr5trvSSEgDzGQaMI2uRFsEBa7+6X5Bt8H3AkrabEimmxPKvIZRuUnuUK3d/Lb2Wzf2bQ+WeT58ExJPSxm/Kla3gaQrs/aoN4QEA4DAmLdsgR2j1N44dWXY8WEFxLgoAgb2JJAnpSBxdKBFhG4pxXyMyi6nejI5uhtesY4R7WFJdqfSYlXe2Bhwt8dkQmCQ6yLC4aA7rqyRetd1Kv70ceLPLCAmQ0aizInhqsB5AS/suQmFONGx2iVstowZY+5LtXYvpwxzU7BQcnrzigBvGkHUDzOHIjMWKLcbp0m2uxRe3W3bU820Q2YSzSE02fo6JtSn/Q==&buyer_id=2088532210434327&invoice_amount=0.01&notify_id=2023070601222102451034321452749628&fund_bill_list=[{\"amount\":\"0.01\",\"fundChannel\":\"ALIPAYACCOUNT\"}]&notify_type=trade_status_sync&trade_status=TRADE_SUCCESS&receipt_amount=0.01&app_id=2021004100619249&buyer_pay_amount=0.01&sign_type=RSA2&seller_id=2088641367241774&gmt_payment=2023-07-06 10:24:50&notify_time=2023-07-06 10:24:51&version=1.0&out_trade_no=20230706102437_1_测试&total_amount=0.01&trade_no=2023070622001434321426379377&auth_app_id=2021004100619249&buyer_logon_id=133****8778&point_amount=0.00";
//Console.WriteLine(decodedUrl == str);
//Console.WriteLine("------------------------------------------------------------------------------");
//bool? b = true;
//bool? b2 = null;
//bool? b3 = false;
//Console.WriteLine(b.Value);
//Console.WriteLine((bool)b2);
//Console.WriteLine(b3.Value);
//string str = "20230706102437_1_测试";
//string userID = "", goodsID = "";
//int n = str.IndexOf("_");
//int m = str.IndexOf("_", n + 1);
//userID = str.Substring(n + 1, m - n - 1);
//goodsID = str.Substring(m + 1);
////增加时长后为多少（需判断当前时间，如果是会员累加，不是会员从今天算起）
//DateTime time = new DateTime();
//DateTime nowtime = DateTime.Now;//当前时间
//DateTime end = DateTime.Parse("2001-01-01 00:00:00");//数据库记录时间
//TimeSpan span = end.Subtract(nowtime);//时间差
//if (span.Days > 0)
//{
//    time = end;
//}
//else
//{
//    time = nowtime;
//}
////根据商品ID判断金额增加时长
//switch (goodsID)
//{
//    case "Y001":
//        time = time.AddYears(1);
//        break;
//    case "M110":
//        time = time.AddMonths(6);
//        break;
//    case "M011":
//        time = time.AddMonths(3);
//        break;
//    case "M001":
//        time = time.AddMonths(1);
//        break;
//    case "D111":
//        time = time.AddDays(7);
//        break;
//    case "D001":
//        time.AddDays(1);
//        break;
//    default:
//        time = time.AddMonths(1);
//        break;
//}
//Console.WriteLine(time.ToString());
//Console.WriteLine($"update atombits.USER set endtime='{time}' where id={userID};");

Class1 class1 = new Class1("小明");
string a = "假的";
class1.Test(ref a);
Console.WriteLine(a);