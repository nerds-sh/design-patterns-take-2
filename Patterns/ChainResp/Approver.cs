namespace ChainResp;
abstract class Approver
{
    protected Approver Supervisor;

    public void SetSupervisor(Approver supervisor)
    {
        this.Supervisor = supervisor;
    }

    public abstract void ProcessRequest(PurchaseOrder purchase);
}