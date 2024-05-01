// 2維陣列

// row 橫排
// column 直排

int[,,] nums = {
    {
        { 1, 2, 3 },
        { 4, 5, 6 },
        { 7, 8, 9 }
    }
};

int[,] num = new int[3, 4];
num[0, 0] = 3;
num[0, 1] = 4;

Console.WriteLine(nums[0, 2, 1]);

