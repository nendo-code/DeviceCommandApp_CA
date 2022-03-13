using DeviceCommandApp.UseCases.DataAccessInterface;

namespace DeviceCommandApp.Gateways
{
    /// <summary>
    /// モーター累積移動量リポジトリ
    /// 今回はオンメモリにデータを持つのでここで実装する。
    /// データベースに保存するのであればさらに上位にデータベースアクセス用のフレームワーク層などを実装し、
    /// そこ経由でデータの永続化をするのがよい。
    /// </summary>
    public class MotorCounterRepository : IMotorCounterRepository
    {
        private int counter;
        public int ReadCounter()
        {
            return counter;
        }

        public void SaveCounter(int data)
        {
            counter = data;
        }
    }
}
