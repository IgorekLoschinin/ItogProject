namespace ControlWork {

    class StringSearcheCollection {

        public void Run() {

            test_1();
            test_2();
            test_3();

        }

        // Через коллекцию List
        public List<string> StringSearchByLenV1 (string[] arr) {
            
            List<string> resultArr = new List<string>();

            if (arr.Length == 0) {
                Console.WriteLine("Передоваемый массив строк для поиска пуст.");
                return resultArr;
            } 
            
            foreach (string item in arr) {
                if (item.Length <= 3) {
                    resultArr.Add(item);
                }
                
            }

            return resultArr;

        }

        public List<string> StringSearchByLenV2 (string[] arr) {
            
            List<string> resultArr = new List<string>();

            if (arr.Length == 0) {
                Console.WriteLine("Передоваемый массив строк для поиска пуст.");
                return resultArr;
            } 
                    
            for (int i = 0; i <= (arr.Length / 2); i++) {
                
                if (i < (arr.Length / 2)) {
                    if (arr[i].Length <= 3) {
                        resultArr.Add(arr[i]);
                    }

                    if (arr[arr.Length - i - 1].Length <= 3) {
                        resultArr.Add(arr[arr.Length - i - 1]);
                    }

                } else {
                    if (arr[i].Length <= 3) {
                        resultArr.Add(arr[i]);                        
                    }
                }                

            }

            return resultArr;

        }

        public void Print(List<string> arr) {
    
            Console.WriteLine($"['{String.Join("', '", arr)}']");            

        }

        public void test_1 () {

            string[] testArrayStr = new string[4]{"hello", "2","world",":-)"};

            List<string> resultString_v1 = StringSearchByLenV1(testArrayStr);
            Print(resultString_v1);

            List<string> resultString_v2 = StringSearchByLenV2(testArrayStr);
            Print(resultString_v2);

        }

        public void test_2 () {

            string[] testArrayStr = new string[4]{"1234","1567","-2", "computer science"};

            List<string> resultString_v1 = StringSearchByLenV1(testArrayStr);
            Print(resultString_v1);

            List<string> resultString_v2 = StringSearchByLenV2(testArrayStr);
            Print(resultString_v2);
            
        }

        public void test_3 () {

            string[] testArrayStr = new string[3]{"Russia", "Denmark","Kazan"};

            List<string> resultString_v1 = StringSearchByLenV1(testArrayStr);
            Print(resultString_v1);

            List<string> resultString_v2 = StringSearchByLenV2(testArrayStr);
            Print(resultString_v2);
            
        }

    }

    class StringSearcheArray {

        public void Run() {

            test_1();
            test_2();
            test_3();

        }

        public string[] StringSearchByLenV1 (string[] arr) {
            
            string[] resultArr;

            if (arr.Length == 0) {
                Console.WriteLine("Передоваемый массив строк для поиска пуст.");
                resultArr = new string[]{""};
                return resultArr;
            } 
            
            string trueStrInArr = "";
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i].Length <= 3) {
                    trueStrInArr += $"{arr[i]} ";
                }                
            }
            resultArr = trueStrInArr.Trim().Split(" ");

            return resultArr;

        }

        public void Print(string[] arr) {
    
            Console.WriteLine($"['{String.Join("', '", arr)}']");            

        }

        public void test_1 () {

            string[] testArrayStr = new string[4]{"hello", "2","world",":-)"};

            string[] resultString_v1 = StringSearchByLenV1(testArrayStr);
            Print(resultString_v1);

        }

        public void test_2 () {

            string[] testArrayStr = new string[4]{"1234","1567","-2", "computer science"};

            string[] resultString_v1 = StringSearchByLenV1(testArrayStr);
            Print(resultString_v1);
            
        }

        public void test_3 () {

            string[] testArrayStr = new string[3]{"Russia", "Denmark","Kazan"};

            string[] resultString_v1 = StringSearchByLenV1(testArrayStr);
            Print(resultString_v1);
            
        }

    }

}