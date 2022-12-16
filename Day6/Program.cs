// See https://aka.ms/new-console-template for more information


int TuningTrouble(string message, int distinctCharacter)
{
    for (var i = distinctCharacter; i < message.Length; i++)
    {
        if (message.Skip(i - distinctCharacter).Take(distinctCharacter).Distinct().Count() == distinctCharacter)
        {
            return i;
        }
    }

    return 0;
}

var stringName = "cbhbmmqnmmqvqfqgqcqmmtvvvdsvscvssmfmhfmhhgdgcclhlnnvmnvmnnwngnqggqlqhhbqbf" +
                 "bvffcpfcfpcpmcppsgssvcvmmdwmwsmwswnwvnvvtgvgfgqqnlltgllpplhpllrnrwrtrzrlrz" +
                 "llpnlpnplnlwnnzfztzcchczctcbbpwpbbfhhqllgrllnnghnnlnznzzlqqmggqbgbjjlnlnjl" +
                 "lwlnwnjnbjnnhhcddgmdmqmllfjllddmgmpggtvvqqwmmhcmmjpjdpdqqnhhqbhhscstsvttbw" +
                 "twdtwwjffvccrwrvvnqqtwwhgwhwthwthhvshsfsjstshthqqdfdhdqhqrqggfffvhffhbbwtb" +
                 "tvtwvvwgvvjjjvtjvvlmlmtmztmthmhttjwwmqqjffhvhqvvrddbsbfbgffmcfffqqfzzgmggz" +
                 "vggbjjmccftcftfnttqqjzjdzdrrgvgsgvvlqvlqqlplnnjccjqcjcgjgfjgjlgjjzhhjbbbfd" +
                 "bfddgccncppsbbjjsttcqtqgqpqllqggtsthhtvvtrttbthtnhhddvnnbggmtggcsgcscmmvml" +
                 "lttjbjggbzbttrfttgsstwtftdthdththbttcggdldtdlttbvvpgpjpwpwvwcwjwsjsttznztz" +
                 "ftzzjpzzrtzrztrrtsrrdtrdtdbdhhdgdwwnjnnvjvsjjrwjjvrrzvrvllrgghgbbgbsssslql" +
                 "rllbjbttzfztzpzzvtvccszsddtqttjllqgqgpqphptpwttwtmtltljjfnnzwzmzlzssghssqh" +
                 "hphbhfftwwqmwmzzqtzqzqrrndrrmrqrzrszzrcrbccglgcgwgrgdggtvtpptgtfgflglgrrnv" +
                 "rvhrrhlrhhfchfhdhzzwggvbbgfgrrpdrdccfllqflfmlfmlmbbhnbbsblbzbgbqqjppcddcvv" +
                 "sddjfjjlnnwbbflfzzmlmddjssjffcqffwdfdqqphpnhppbttjfjzzdvdjvvddnfffmjfmfmpf" +
                 "mmmdlmlrrhqqcpcmclmmbmppzczjjmlltqlqzzqgqcggdmdzznnnnsjjvbjjwbwhbhfhvvtmms" +
                 "fmmcgmcmwcwhwnhhpccmbmdbmbgbjbggqqccfllfqqmqwwzbblffthhdnncqnccqppldlpldpl" +
                 "lzmmsqqdffnggqlqtllwlglnlnhlhflfssvzzrllbtbnbgnnfvfllwslszswsnnpwwppvspsmm" +
                 "nfnpffrmrhmmctttrjrbjrjpjtpjpssdwdtwtmmtgtsgttlwttfrfvvpjpcjccmtthhldhllzs" +
                 "lshhnrnvvfddnllltclcrrhnnjwwwpfpddmtmsmfflslrlmlmwmllgfgmfgmmjttpcpspslsjs" +
                 "psqstqsqqpsprphrrpqqfzqqwcwcddsjjpvvfnfvnnnrncnwcwczzcwzwnwmwffbdfbdfdjjhr" +
                 "hvhhvwvsvhshnhwwzlwlnnphhtjjmljjqzjjsjgsjshhwjjmttvgvsgstggrcrmmrqrhrqrzrm" +
                 "zmggqvqtqgtqqqqltqqwggmmzggjccgmgwgqqmnqnrnprptrrvfrvffnmnfmmnnnwzzldlvlgv" +
                 "lvqqpnphpgglhlshlhzzpcptpssblqvdbpbbcrngctqgptccwpdcpbcjwdmcrzmhwffgzqmmqw" +
                 "pqvplwzmjlzmvmzmbtqjnhzrpppnpntvmjbzmvhjvbgflmmjnwssvqvbnbddfcwqdtvpvddctm" +
                 "pptcjmvwszhbsttcbjlfjvwlljhlqlvvsnzphdjhfswltdhzprltzcszrgcmnmfznmbccstjvj" +
                 "ngwpbsfqssfwvpdhhmlmzttzlszsgpvvbcfvzrlsttlqpnqhwtbqfjnbztnwfnhlhfltgdtsrr" +
                 "wrfhlssvsgzpffnnrhgcvclqnjgfhhzswllvcjffpngcmtjphwnbdfrrgjfrfqbnvbwgccsjvv" +
                 "mjgcvqvtggnvgvgnnchbblqnvvdgjtvdmfrzvhvhzcbqzdslphjjqtcwjqptstvvpqgdbgbcmm" +
                 "chjpvjhvbwtlmlnqpldfcbmwvrmpqcsfdhmmwnbvmpglcfbnsgjmljcwpzpwffcqfrbdrztzhq" +
                 "zhzpcrjfdmrctttdrzlmzcqwjftngwjmgqscftnpbjwqrcvqwbwbdhbhvrdcvgrvctjgwjtmdg" +
                 "zwgvdbmsrjpsbhwcqlqzjnzmgpctlwqhfnbmgsprjcqtfjjvzljqpfqgnvrgnjjlmpqgnzpmps" +
                 "vzjmtvnfgslldjtjdwlzrvqrbvcpspzpcdnpdjmhcdhsbmthmgjqchqwwsnfjnwgpctlwcdpqp" +
                 "mzqcrptscngqnmhzwjdcqwvdmlzntsfbstbtmmnlsspjbjjdspnslgcnlbfnbhjlzjhrrmdbbw" +
                 "tswqpbpwtzhcnldbsfrvndzvcgzjprcrclhfwbvzgthcglfzqrshgtvbflvnznhmlzdtfnrslt" +
                 "nnppqgrtndbsfqmftdnzmqfwdpcrmssldmrrnzchnqpflgbqzqjjrzlfnptqdwzdhmctfbztmf" +
                 "cmbqcwjmgnwgqzqjctphrrthgvpvppztvpzgzhdszfhlzlcnwmfrlsnvftfrlfvbnlwzctphhp" +
                 "fvszntqcvnfmvmwwhsjlnpfhcpjvrncgmsbprwwllvnsbjfhtbtmcvvpzcvqrrqdvgzvllvcvn" +
                 "vvbftngqcqcvvbsqfshmnhwptcsbsnjzltqzmflftrhblqszrzsbfcpgzncvwhlqlcbmgjdpfc" +
                 "mlgdfphsfcgqccthmlzjbdwpsbddwwrtwmsvqwbzwhzmghhrspvbptznqsqvhgnhlwqjnhgnzp" +
                 "rrtjddwtqfsshjrvlglhdlstghftmllvzmmfglnscnrtgcwwwzjphzhvqlctdwjlqvbsvlgzrd" +
                 "pvjhhcthgjhlwsgfzlschhfprfcrzfrzmnlwvqsnqlllczwfhswchrlggqszwrvpldrffnzrff" +
                 "bhtfbslgcdrqpjcrbqsrgfrhttcptncfndcbsdbjsqjvgbmnmhlnbltdcgbmllpgjmgljvglrw" +
                 "mrvgthhhzrsmzvgwcfgvcsbzpjcqnhrzhznzjcjghhwqvllrmsvlpzlssrdsqwvzvqwsvfsjqv" +
                 "bgrfbmfzlchqsjgncbljtvzsfdnvmfzcbrlnnvvmjbmgjmqzjtdzpljdwqtvwsrlbslwfvlgbt" +
                 "nmlpcwmngncnmdhqctshmjmnhpqcqzhvlbvgptctrvggdgnpnrlnngrfhsqdfthvcnpwjfjnsl" +
                 "cqlfrfvhnctmsqgnqmgpwtlzhtdqhqqrcllzjccnszsqvrzhcffvnfnstgdmljdrqrndljdnfb" +
                 "bjvmpqdnqhtdlnzcvnfjlvzmfzrndhtglvngmbrdbpbnhvfmrbcwqzttnjplgrhchjtfjwfbjf" +
                 "bmzlrnllhzccpfhfhnjpfvzlpbqnhwmpssvwtzhdbtnbtllhpfdcqjjnzgbdrfjjbcltnzdrmt" +
                 "msmvpjtmdnqszgbqncsvhjbgwswhmghpvstrqbglgrtgbchttbznvvdhppzwnttpgcbdjdhlsq" +
                 "hhtlphjjrjncrmfdtjhdwmjgmpngnbptzwgwdztmhtpglnftwpnnmrmcwfhwnhlsbwsrjnlmdl" +
                 "mffbzsnhsvnbldwtrrhdhfsjdrsnzlgtfzcwwqrfhtrmjhmphqndwtbpczvmfgczmdlqjqdlwm" +
                 "vjjzwmqnpvwzmtjwtprlnbvjdhpjgndrwzcfthnwhnhqpwtcjlhrhdplzsncfmszmhjmgljhnl" +
                 "srrfwplclcvjjqmtpnwbtsbwdnjdlqntvdnfgwbpwspssprbffjdlcvbwcqlttnwnhwdspfsjh" +
                 "ppbhspnrvrsfmzvbwwtjfzmnzwgqddbmcjzzqhqlgrglsvgsjdwlnsbtmqgsnfwwqrjsbcgdlm" +
                 "bgqwvgpqllqwbcplfjrgnzsdtdtvqnrbcrqjhdtqqplvszvtlflgbpwnpzczbvhzfjrslcwcsw" +
                 "sgfvvsswzzwhtfjfpsrvcfnrs";

Console.WriteLine("Part One Answer: " + TuningTrouble(stringName, 4)); //1658
Console.WriteLine("Part Two Answer: " + TuningTrouble(stringName, 14)); //2260
