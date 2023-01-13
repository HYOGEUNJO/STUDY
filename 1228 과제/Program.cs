namespace 과제_조효근_20221228
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 카드뽑기 게임
            // 컴퓨터가 2장을 뽑아서 보여준다. (패스는 0포인트 베팅)
            // 플레이어가 뽑은 카드가 컴퓨터가 뽑은 2장의 카드 사이에 있는 카드라면 플레이어가 2배 벌어간다.
            // 플레이어가 뽑은 카드가 컴퓨터가 뽑은 2장의 카드 사이에 없다면 플레이어는 베팅금액을 잃음.
            // 플레이어는 10,000 포인트 들고 게임을 시작함.
            // 카드의 대,소 비교는 오직 숫자로만.
            // 게임 종료는 100,000 포인트를 벌거나, 모두 잃을 때.

          

            PickUpTheCard start = new PickUpTheCard();

            start.GameInit();






















        }
    }
}