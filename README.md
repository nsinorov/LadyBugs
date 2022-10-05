## LadyBugs

You are given a **field size** and the **indexes where ladybugs** can be found on the field. On every new line, until the **"end"** command is given, a ladybug **changes its position** either to its **left** or to its **right** by a given **fly length**. 

A movement description **command** looks like this: "0 right 1". This means that the little insect **placed on index 0 should fly one index to its right**. If the ladybug **lands on another ladybug**, it **continues to fly in the same direction repeating the specified flight length**. If the ladybug **flies out of the field**, it is **gone**.

For example, you are given a **field of size 3**, where there are ladybugs on indexes **0 and 1**. If the ladybug **on index 0 needs to fly to its right by the length of 1** (0 right 1), it will attempt to **land on index 1** but as there is **another ladybug** there, it will continue further to the right passing 1 index in length, landing on **index 2**. 

After that, if the same ladybug needs to fly to its right passing 1 index (2 right 1), it will land somewhere **outside** of the field, so it flies **away**:
