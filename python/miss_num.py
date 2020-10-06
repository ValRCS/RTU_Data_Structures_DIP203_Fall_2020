import random
MAX = 50
MISSING = 2
nums = [str(n)+"\n" for n in range(1, MAX+1)]
random.shuffle(nums)
print(nums)
nums.pop()
with open("missing_number.txt", "w") as f:
    f.writelines(nums)
