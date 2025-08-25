// おみくじ
string[] omikuji = new string[5];
omikuji[0] = "0 大吉";
omikuji[1] = "1 中吉";
omikuji[2] = "2 吉";
omikuji[3] = "3 凶";
omikuji[4] = "4 大凶";

//string[] omikuji = { "0大吉", "1中吉", "2吉", "3凶", "4大凶" };

//各おみくじを何回引いたかを格納する配列
int[] count = new int[5];

//Randomクラスを実体化して変数randが機能を参照できる
Random rand  = new Random();

//for (int i = 0; i < 100; i++)
//{
//    int result = rand.Next(0, 5); //0以上5未満のランダムを取得して、変数resultに代入

//    //result番目の値を配列から引っ張てきてコンソールに出す
//    Console.WriteLine((i + 1) + "回目の結果　　" + omikuji[result]);
//    count[result]++; //resultで引いた結果の番号をカウント
//}


//大吉をひくまで繰り返すループ
bool end = false; // 終わりフラグ
while (end == false)  //endはfalseであるかどうか　→成立していれば繰り返し
{
    int result = rand.Next(0,5); //0以上5未満のランダムを取得して変数 resultに代入
    Console.WriteLine(omikuji[result]);
    count[result]++; //resultで引いた結果の番号をカウント

    //もし大吉を引いていたら変数endはtrue
    if (result == 0)
    {  end = true; }
}


//配列conutの結果を順番に発表
for (int i = 0; i < count.Length ; i++)
{
    Console.WriteLine(omikuji[i] + "は" + count[i] + "回引きました。" ) ;
}



//bool end = false; //論理型　終わりフラグ
////いつ終わりが来るかわからないループ
//while (end == false)
//{
//    int dice = rand.Next(1, 7); //1～6のランダム
//    if (dice == 1)
//    {
//        end = true;
//    }
//    Console.WriteLine("つづく");
//}