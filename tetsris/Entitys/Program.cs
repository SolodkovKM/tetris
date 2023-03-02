namespace EntityesClass
{
    public class Entity
    {
        public string? type; // T, Г, |, Z
        public int x;
        public int y;
        public int rotation = Random.Shared.Next(0,4); // 0 - up, 1 - right, 2 - down, 3 - left
        public Entity CreateEntity()
        {
            Entity TEntity = new Entity().TEntity();
            Entity rEntity = new Entity().rEntity();
            Entity lEntity = new Entity().lEntity();
            Entity ZEntity = new Entity().ZEntity();
            Entity[] Entityes = new Entity[4]{TEntity, rEntity, lEntity, ZEntity};
            Entity RandomEntity = Entityes[Random.Shared.Next(0,4)];
            return RandomEntity;
        }
        void EntityPosition()
        {
            this.x = Random.Shared.Next(2,14);
            this.y = 1;
        }
        Entity TEntity()
        {
            this.type = "T";
            this.EntityPosition();
            return this;
        }
        Entity rEntity()
        {
            this.type = "r";
            this.EntityPosition();
            return this;
        }
        Entity lEntity()
        {
            this.type = "l";
            this.EntityPosition();
            return this;
        }
        Entity ZEntity()
        {
            this.type = "Z";
            this.EntityPosition();
            return this;
        }
    }
}