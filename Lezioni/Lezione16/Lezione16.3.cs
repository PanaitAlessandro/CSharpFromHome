public class A
{
    public virtual string Chi()
    {
        return "A";
    }
}

public class B : A
{
    public override string Chi()
    {
        return "B";
    }
}

public class C : B
{
}

public class D : A
{
}

// l'output se chiamiamo un main sarà:

// "A", "B", "B", "A"