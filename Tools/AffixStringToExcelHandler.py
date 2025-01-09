mapping = {
    "Maximum Life": "MaxHealth",

    "Resistance to All Elements": "AllResistance",
    "Cold Resistance": "ColdResistance",
    "Fire Resistance": "FireResistance",
    "Lightning Resistance": "LightningResistance",
    "Poison Resistance": "PoisonResistance",
    
    "Thorns": "Thorns",
    "Armor": "Armor",
    
    "Critical Strike Chance": "CriticalChance",
    "Critical Strike Damage": "CriticalDamage",
    "Vulnerable Damage": "VulnerableDamage",
    "Overpower Damage": "OverPowerDamage",
    "Attack Speed": "AttackSpeed",
    "Lucky Hit Chance": "LuckyHitChance",

    "Intelligence": "Intelligence",

    "Movement Speed": "MovementSpeed",
}

class Result:
    target_stat = ""
    modifier_type = ""
    value_range = ""

    def __init__(self, target_stat, modifier_type, value_range):
        self.target_stat = target_stat
        self.modifier_type = modifier_type
        self.value_range = value_range


def parse_string(input_str, mapping):
    lines = input_str.strip().split("\n")
    results = []
    
    for line in lines:
        # 提取方括号内的内容和后面的描述
        bracket_content = line[line.find("[") + 1:line.find("]")]
        description = line[line.find("]") + 1:].strip()
        
        should_continue = False
        for key in mapping.keys():
            if key in description:
                should_continue = True
                break

        if not should_continue: continue

        # 根据映射关系替换描述
        for key, value in mapping.items():
            if key in description:
                description = description.replace(key, value)
                break
        
        # 判断是 Flat 还是 PercentAdd
        if "%" in description:
            modifier = "PercentAdd"
            # 去除描述中的百分号
            description = description.replace("%", "").strip()
        else:
            modifier = "Flat"
        
        # 处理数字范围
        numbers = bracket_content.split(" - ")
        numbers = ",".join(numbers)
        
        # 构建最终输出
        # output = f"{description} {modifier} {numbers}"
        output = Result(description, modifier, numbers)
        results.append(output)
    
    return results

# 输入字符串
input_str = """
[424 - 457] Maximum Life
[4 - 9] Life per 5 Seconds
[11 - 13]% Healing Received
[226 - 285] Armor
[5 - 6]% Dodge Chance
[10 - 12]% Resistance to All Elements
[40 - 50]% Cold Resistance
[40 - 50]% Fire Resistance
[40 - 50]% Lightning Resistance
[40 - 50]% Poison Resistance
[40 - 50]% Shadow Resistance
[7 - 8]% Impairment Reduction
[276 - 285] Thorns
[1 - 2] to Basic Skills
[107 - 121] Intelligence
[2 - 3] to Arc Lash
[2 - 3] to Fire Bolt
[2 - 3] to Frost Bolt
[2 - 3] to Spark
"""

def main():
    output = parse_string(input_str, mapping)
    for i in output:
        print(f"{i.target_stat}")
    
    for i in output:
        print(f"{i.modifier_type}")
    
    for i in output:
        print(f"{i.value_range}")
    


if __name__ == "__main__":
    main()