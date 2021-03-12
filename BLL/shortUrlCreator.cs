namespace urlShortner.Bll
{
    public class shortUrlCreator
    {
        public static string shortner(string filePath)
        {
            string shortUrl;
            byte[] byteText;
            
            using (System.IO.StreamReader fileReader = new System.IO.StreamReader(filePath))
            {
                byteText = System.Text.Encoding.ASCII.GetBytes(fileReader.ReadLine());

                if (byteText[2] <= 122 && byteText[1] <= 122 && byteText[0] <= 122)
                {

                    if (byteText[2] < 122)
                    {
                        byteText[2] += 1;
                    }
                    else
                    {

                        if (byteText[1] < 122)
                        {
                            byteText[2] = 97;
                            byteText[1] += 1;
                        }
                        else
                        {

                            if (byteText[0] < 122)
                            {
                                byteText[2] = 97;
                                byteText[1] = 97;
                                byteText[0] += 1;
                            }
                            else
                            {
                                // set letters to out of range!
                                byteText[2] = 126;
                                byteText[1] = 126;
                                byteText[0] = 126;
                            }

                        }

                    }

                }
                else
                {
                    // letters are out of range!
                    byteText[2] = 82;
                    byteText[1] = 82;
                    byteText[0] = 69;
                }

            }

            using(System.IO.StreamWriter fileWriter = new System.IO.StreamWriter(filePath))
            {
                shortUrl = System.Text.Encoding.ASCII.GetString(byteText);
                fileWriter.WriteLine(shortUrl);
            }

            return shortUrl;
        }
    }
}