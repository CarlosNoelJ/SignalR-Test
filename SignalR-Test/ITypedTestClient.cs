using System.Threading.Tasks;

namespace SignalRTest
{
    public interface ITypedTestClient
    {
        Task BroadcastMessage(string type, string payLoad);
    }
}
