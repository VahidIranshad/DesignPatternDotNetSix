namespace Observer.FirstImplementation
{
    internal class Subject
    {
        private string Color = "Black";
        private List<Form> _observers = new List<Form>();

        public void Attach(Form observer)
        {
            Console.WriteLine($"Attached an observer.{observer.GetType().Name} : {observer.Color} dateCreated: {observer.dateCreated.ToLongTimeString()}");
            this._observers.Add(observer);
        }

        public void Detach(Form observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine($"Detached an observer.{observer.GetType().Name} : {observer.Color} dateCreated: {observer.dateCreated.ToLongTimeString()}");
        }

        public void Notify()
        {
            Console.WriteLine("Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Update(Color);
            }
        }

        public void ChangeColor(string color)
        {
            Console.WriteLine("\nSubject: I'm changing color");

            Color = color;

            this.Notify();
        }
    }
}
