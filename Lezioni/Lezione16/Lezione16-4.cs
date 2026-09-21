public class A
{
    public virtual string Chi()
    {
        return "A";
    }
}

public class B : A
{
    public sealed override string Chi()
    {
        return "B";
    }
}

public class C : B
{
    // ho messo sealed in classe B, quindi questa classe non potrà fare nulla
}

public class D : A
{
}

public class E : B
{
    // ho messo sealed in classe B, quindi questa classe non potrà fare nulla
}

public class F : E
{
        // ho messo sealed in classe B, quindi questa classe non potrà fare nulla
}

// l'output se chiamiamo un main sarà:

// "A", "B", "B", "A"


// posso fare una sealed delle classi, ciò significa che nessuna classe può diventare sua figlia