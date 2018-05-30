namespace ShoesFabricBridge
{
    public class BaseShoe : IShoe
    {
        protected readonly IMaterial material;

        public BaseShoe(IMaterial material)
        {
            this.material = material;
        }
    }
}