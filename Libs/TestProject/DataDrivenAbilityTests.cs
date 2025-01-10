using Dumpify;
using RPGCore.Abilities;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace TestProject;

public class DataDrivenAbilityTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Deserialize()
    {
        var ability = new DeserializerBuilder()
            .WithNamingConvention(UnderscoredNamingConvention.Instance)
            .Build()
            .Deserialize<DataDrivenAbility>(File.ReadAllText("TestAbility.yaml"));
        ability.Dump();
    }

    [Test]
    public void Serialize()
    {
        var ability = new DataDrivenAbility
        {
            Name = "Fireball",
            IconName = "Fireball",
            OnActive = [new AbilityAction
            {
                AbilityActionType = AbilityActionType.FireProjectile,
                ProjectileName = "Fireball",
                Rotation = 0f,
            }]
        };
        var serializer = new SerializerBuilder()
            .WithNamingConvention(UnderscoredNamingConvention.Instance)
            .Build();
        Console.WriteLine(serializer.Serialize(ability));
    }
}