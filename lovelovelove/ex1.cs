namespace ExOne{
    public class A{
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public B BClass { get; set; }
    }

    public class B{
        public int Id { get; set; }
        public string NickName { get; set; }
        public string Description { get; set; }
        public A AClass { get; set; }
        public B(){}
        public B(int _Id, string _Nickname, string _Description) {
            Id = _Id;
            NickName = _Nickname;
            Description = _Description;
        }
    }
}