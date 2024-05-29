public class MoveController<T> where T:IMovable
{
    public void MoveObject(T movable)
    {
        movable.Move();
    }
}
