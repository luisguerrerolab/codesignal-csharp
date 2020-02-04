using System.Collections.Generic;
using Xunit;

namespace codesignal
{
    public class HashTablesTest
    {
        readonly HashTables _hashTables;
        public HashTablesTest()
        {
            _hashTables = new HashTables();
        }

        public static IEnumerable<object[]> GetData_GroupingDishes()
        {
            yield return new object[] {
                new string[][] {
                    new string[] {"Salad", "Tomato", "Cucumber", "Salad", "Sauce"},
                    new string[] {"Pizza", "Tomato", "Sausage", "Sauce", "Dough"},
                    new string[] {"Quesadilla", "Chicken", "Cheese", "Sauce"},
                    new string[] {"Sandwich", "Salad", "Bread", "Tomato", "Cheese"},
                },
                new string[][] {
                    new string[] {"Cheese", "Quesadilla", "Sandwich"},
                    new string[] {"Salad", "Salad", "Sandwich"},
                    new string[] {"Sauce","Pizza","Quesadilla","Salad"},
                    new string[] {"Tomato", "Pizza", "Salad", "Sandwich"}
                }
            };

            yield return new object[] {
                new string[][] {
                    new string[] {"First", "a", "b", "c", "d", "e", "f", "g", "h", "i"},
                    new string[] {"Second", "i", "h", "g", "f", "e", "x", "c", "b", "a" },
                },
                new string[][] {
                    new string[] {"a","First","Second"},
                    new string[] {"b", "First", "Second"},
                    new string[] {"c","First","Second"},
                    new string[] {"e","First","Second"},
                    new string[] {"f","First","Second"},
                    new string[] {"g","First","Second"},
                    new string[] {"h","First","Second"},
                    new string[] {"i","First","Second"},
                }
            };

            yield return new object[] {
                new string[][] {
                    new string[] {"uRorJcdDY","xJVvhlstGduVCXdFdujXTgXVEFKNPihHy","RTqElOHEezrX nuiqwwjQuduOjRXLHetcNi"},
                    new string[] {"jXlQq SrprXjalWAalgrKWi", "LzKHPaVumdHOkMcEIVvGPPXzPacaMFDCihcMgqSjIwDoOz", "XJqYoHutT", "HkgftoPkGEMYBrBsslHSNDgaT UFAU"},
                    new string[] {"MPHvPdMMvfOWJwwsgtDMHDfzvtfj","xJVvhlstGduVCXdFdujXTgXVEFKNPihHy","ehXldhlmrqzKkHnGaJEAekZZMENOk","XJqYoHutT","HkgftoPkGEMYBrBsslHSNDgaT UFAU"," vRMbRCxdUNLUAWPDUaOvAYXLrdSIbIkzP"},
                    new string[] {"ciZulBnp","XJqYoHutT"},
                    new string[] {" BD"," Z"},
                    new string[] {"NISBU","HkgftoPkGEMYBrBsslHSNDgaT UFAU","xJVvhlstGduVCXdFdujXTgXVEFKNPihHy"," vRMbRCxdUNLUAWPDUaOvAYXLrdSIbIkzP","okimoDeuEXNGoYLAAKvtoWedxISQdQwtQjyrf","vQQbvBHSuZttPUROnejivETZmoVrkIjO","ehXldhlmrqzKkHnGaJEAekZZMENOk","rBQBijEyYSEiAZQJynEoxYGr","XJqYoHutT"},
                    new string[] {"nkcnw"," vRMbRCxdUNLUAWPDUaOvAYXLrdSIbIkzP","MdL"},
                    new string[] {"tydbbwew","RTqElOHEezrX nuiqwwjQuduOjRXLHetcNi","LzKHPaVumdHOkMcEIVvGPPXzPacaMFDCihcMgqSjIwDoOz"},
                    new string[] {"qXFBLadpZBCbrRmXqNbrMdjMxDqHTMaOiMlFgvDWSHRqjBiR","sodHEaIwzVUjuSKVCQmYcHseYGwkVhMBVJTHsmNQBDn","rBQBijEyYSEiAZQJynEoxYGr"," Z","XJqYoHutT","HbHrfihXcoDiPVWXjLRAjGjOKPsjZ","MdL","GMjxXomTxfhoWfQJMbFcCe rUYgypPKDdtWzrXJ"},
                    new string[] {"DtBNFbSVPAmlaimKltbvhTw","HbHrfihXcoDiPVWXjLRAjGjOKPsjZ","LUFxPN YSBUcdjciFSvCNReRdEdZhQAcjNDncRdMjxzhKnvS","nGtuuzyUNzaZtsHyCcNDRWxsDeDToZmZCyGGLQh","eKIk","rBQBijEyYSEiAZQJynEoxYGr"},
                    new string[] {"yeW NrisSXpCqBODhvjPCc BxsAPvVjncCmrCmtzWwzTkGTWc","HsVTdoHcaWOdKXzlHtBTEyiboE","HbHrfihXcoDiPVWXjLRAjGjOKPsjZ","uCHUcxsSkAxGYuUTXWvUsmEOXwxYZS RBVfxdAJire","NcHcrvrT"},
                    new string[] {"BBuqbJb","jpXFSxDpTplxEINsATikIPmDLOEnWekweGYIdMd DUWzmGNla","KKgYijjNTJLxDuKOceXXtNitKVqiRcjqoQP","HkgftoPkGEMYBrBsslHSNDgaT UFAU","iKxEovxCHh","vQQbvBHSuZttPUROnejivETZmoVrkIjO","W","mZLsxUptSEJoZngM"},
                    new string[] {"QLnRR WuUncwFugufHgoGWYuRyjFqbcAYBNbGjYXt","XJqYoHutT"," vRMbRCxdUNLUAWPDUaOvAYXLrdSIbIkzP"},
                    new string[] {"uqGDEuIcCsTfALbkYWPobIzPaPsaYstsrypdykdlP","HJuARFInhbbsZDjKScfdytKzYKFwoUdRbAmOumcfQrWWI"},
                    new string[] {"xCjWAXSOkIyNjKMKE","mZLsxUptSEJoZngM","CHpofYYXWRCCMhYAyN","eGRIZbyYkTYotiGADaZddisSLgLUu","PPpFXGhHguPlkVvHFBUqLewPUAxVTFlc","BiKLRaDFbOKeSGAwGvgOmtfCsCZlbMFFTUxrbsAjWMmDMkNa","zuPRYtbrQVgePjgFqhvaISQjOTMFWKKprOnktDnzWkD","eKIk","sodHEaIwzVUjuSKVCQmYcHseYGwkVhMBVJTHsmNQBDn"},
                    new string[] {"wzrouFPrpjH"," Z","yJAnvCYuXQiICtkYPLvbWHtS","CHpofYYXWRCCMhYAyN","eGRIZbyYkTYotiGADaZddisSLgLUu","TjjMOpgjQGWIjAQYTGWcLEyLfCEPYdZ ","TlnOZqSVwPJIVzhZOV","ehXldhlmrqzKkHnGaJEAekZZMENOk","DjOeNqGFcPTawYdAgcGBpzcvdPYGBfHwvKmxrCRLBMzR sh xE","rBQBijEyYSEiAZQJynEoxYGr"},
                    new string[] {"mKtlrKSd mRFufNMBtnctWGuaJlHqtylmoafnAlqabdyBdwOX","MdL","HsVTdoHcaWOdKXzlHtBTEyiboE","TCGlYRRRbGVCDxucaNyzf yKUfXrOUasKOUPyzwRKjiQNAFa Z"},
                    new string[] {"Qli","gUxwpPT wSYuvUvRtSzCnoOqTgt","nGtuuzyUNzaZtsHyCcNDRWxsDeDToZmZCyGGLQh","mZLsxUptSEJoZngM","eKIk","aN Il"},
                    new string[] {"WKAbmPMRGrmCSdNugGNqeyTqqrYLgNZwAgdvVZSFUoo"," vRMbRCxdUNLUAWPDUaOvAYXLrdSIbIkzP","VIJGgvVPncdEMr","mZLsxUptSEJoZngM","RTqElOHEezrX nuiqwwjQuduOjRXLHetcNi"},
                    new string[] {"yrhuhCBAtORzxSRVhjHcwEjppIMtsuJitwvtM","raOLpNloUqVPEOvqyDidmnThyRDShbOWvmV"}
                },
                new string[][] {
                    new string[] {" ","EoscJnpLiNuTriMHwqJdfHPldVJeHlPixTfQEbHLx","WrpDfRkqwoxEPpRY","yQEqGqdyEPmbvAwvXcKkdMGMAsBj ZueUhBvGmNO"},
                    new string[] {" JaXqjGKF", "gXjFQrVSGgecc", "kHRiiwKMslKjdOVQihTWopDjUNCAGkBxQgio g", "sCSQDvWZcdFkRgjcewOlpDQJU"},
                    new string[] {" Z"," BD","qXFBLadpZBCbrRmXqNbrMdjMxDqHTMaOiMlFgvDWSHRqjBiR","umUNKfnZqGrqthHKSyIaPefuw","wzrouFPrpjH"},
                    new string[] {" ZAqJiGBKCGCW","FIGQDc EYDTVNUGNI","YToQlcklF","bqPdvWXAMb"},
                    new string[] {" ZhDsgXm","SoRB","VSIkxI jOyzmjPIoUtcMfMctvLDGyTFgC asLGVFylVFPDY"},
                    new string[] {" aVfyKnwVCWqhYKPUJCcMY","LbNsYbWIbTcqnUNTAtzQqopvcDeCFVgEWufvgVucfFVSL","N ViYvGpMmTrttvLIVrhkKtSevXgOfRaWjetnBQmIwOH","ShRXzulmjhdkGKMjYpJZnKk DhklrHmrOrbXgagCMMcZlMw e","fXpqB AJMkOaVaHwErDjcbbWPCd","nQjsjwDPBwdxZixtoXTdnOIEYmGCbMdXcjucGiGLsKHqtvKey","vWmaAZCiGW"},
                    new string[] {" ajurTSXBetCicnDswPGp","BQziFPx","N ViYvGpMmTrttvLIVrhkKtSevXgOfRaWjetnBQmIwOH","W CmXLKzeLjlKKk"},
                    new string[] {" bE aeInpGxLmhdLzFuEUErJyEmnHfnbHtRsuGoXGmxYlzffep","GERjiJmO","pleyowofrfJmDyhRcmKmSYwEfePlZnSPJKvUlCEwAuE"},
                    new string[] {" eZAhVwR","ELYOYEwWDXUZ IbEZxVqDqTaMQVOh","VCuxEPqWzLSawcFhdDM","iTBQhGPijYi"},
                    new string[] {" ggi caaznYcQtBuORkyqdLpTyQFIxDmGXMxjON pomf","EjPcvrqVqNUYVlngwHqCgcFvJYfKFDFDbgmcDkw","kSreCYKHfuSbXmsCPaKUCfpKYpQWicDymfIs"},
                    new string[] {" gvNKRnPbdGEWjKRQNClHHdQ PZ","DtmXBFptrrhzqqiKKoBIiwTHBHxnnJTzJRpHzEAGqlDOuhh","EiRPhBRTcVJ","WEPxkbIEZJiOpbVzwfeWypWSbp jNJjS"},
                    new string[] {" ivuxnzkAKVySSMBnatPCGdq","GERjiJmO","tBRSihXDIYWniZYlsUgJNXOPYllKXVAR","wXqetAlMl xrYPxiilTZbLPllSJebZkIbumgNHIP"},
                    new string[] {" vRMbRCxdUNLUAWPDUaOvAYXLrdSIbIkzP","MPHvPdMMvfOWJwwsgtDMHDfzvtfj","NISBU","QLnRR WuUncwFugufHgoGWYuRyjFqbcAYBNbGjYXt","TwdHXjYsKMUlGFCoNsNXavbfj","WKAbmPMRGrmCSdNugGNqeyTqqrYLgNZwAgdvVZSFUoo","cdaNBOwZzTfDJKJQEZPEGjDr QPPIViqbUneyzTuRYCEHoyXFd","gHkkXyXnGRLQXcBDQbfGzFWiwRedbEjJkLNeagIXrgK","nkcnw"},
                    new string[] {" yYgLFxmMAmHqKBRhSBzurXCWz","NAWWtVyMGkEioRHErqkXhHZZOUn RDDQd BgEWJCaPUUllbB","ea","kIM wVnjvOGebbIdfdmAg"},
                    new string[] {"A","TstUKhOpYmPCNYKLcgcKrIXlsFdgcXaKEBYvjXgYAohu","yxFFxkNNyGMksd"},
                    new string[] {"A vzJcdhDOYQW","NGvngwGNJpedN","bcYqAUNeFzgxifIkzw yokVdUGQlpUCvsGKsTJrCHwdjFrz","icrgnsnKvucwziCWtoH","psKUGvuCiTxNKcuqJry"},
                    new string[] {"AFOOWgYAcXpkkgKsQexCfkxzyMwNGzNkxoAYHiunejlrD","BhyYDTZmzwjNYFGLd rYoSfHllOVXDhTouRcvTa","dsvGeoETyDEfT"},
                    new string[] {"AKSzlcZ MCoENseIYsDodmtRbK","VQfhZzziGH","YxVasTGnmzmFDwiaCbEWrrFYGgeLFhRo","t yHdEvOpCYPjRnLVEaoGPrUdDdWHAQDTENsj"},
                    new string[] {"AMYdUzCSrxNKTFPgEgFwetENcpUfmCmTloEwETlPHSqzevXxwW","BQziFPx","N ViYvGpMmTrttvLIVrhkKtSevXgOfRaWjetnBQmIwOH","fjizDTojNOPonaOOvzvrfVdmhavCMDEurCIxZN","fqIXnPbenLYmlaWipV"},
                    new string[] {"ANNgDZNiyHOFyzyHwVZbIQOUftifpXWtrHHgQ","SorJhxvhUL","yXsLRxgCDh oP"},
                    new string[] {"AOlCTUkrpnenluMagQpmtblQpgifumvfvZCLvQ ye","Ni SKUptogUpantBCTioBbOicTfHNgExoaHp","SoRB","ea"},
                    new string[] {"APtIhbZLFOinxiByCwMjm","MaNyVCOUowENvyzzGTmlmwio JP SltltgbQspe","cMYrQjrGLQcj"},
                    new string[] {"ARext kQHXFdNyzxTEOyqozbKqYcYPUJHFFLwz","FUZ","suwVcczlaHHxCWZGjqdFHCqoKaUAqvQjA"},
                    new string[] {"AbEaKhTjOYYziWjZkzr EAyBJPVELaA","Yur","axsZlluGJZXfGCpdBDoljO","rXEyHjQaJDuTUbAhDnGpdUmOCLboTUuoIwNL rTsRbjC"},
                    new string[] {"AfAqOmQoLZlKGutGTwW "},
                }
            };
        }

        [Theory]
        [MemberData(nameof(GetData_GroupingDishes))]
        public void GroupingDishes_ShouldWork(string[][] input, string[][] expected)
        {
            var actual = _hashTables.GroupingDishes(input);

            Assert.Equal(expected, actual);
        }
    }
}