using Nancy;

namespace Djaka.Api.Controllers
{
    public class HomeController : NancyModule
    {
        public HomeController()
        {
            Get("", _ => SayHello());
        }
       

        private string SayHello() => @"
                                                                                                                                 
            dddddddd                                                                                                             
            d::::::d jjjj                   kkkkkkkk                                                                       iiii  
            d::::::dj::::j                  k::::::k                                                                      i::::i 
            d::::::d jjjj                   k::::::k                                                                       iiii  
            d:::::d                         k::::::k                                                                             
    ddddddddd:::::djjjjjjj  aaaaaaaaaaaaa    k:::::k    kkkkkkkaaaaaaaaaaaaa          aaaaaaaaaaaaa  ppppp   ppppppppp   iiiiiii 
  dd::::::::::::::dj:::::j  a::::::::::::a   k:::::k   k:::::k a::::::::::::a         a::::::::::::a p::::ppp:::::::::p  i:::::i 
 d::::::::::::::::d j::::j  aaaaaaaaa:::::a  k:::::k  k:::::k  aaaaaaaaa:::::a        aaaaaaaaa:::::ap:::::::::::::::::p  i::::i 
d:::::::ddddd:::::d j::::j           a::::a  k:::::k k:::::k            a::::a                 a::::app::::::ppppp::::::p i::::i 
d::::::d    d:::::d j::::j    aaaaaaa:::::a  k::::::k:::::k      aaaaaaa:::::a          aaaaaaa:::::a p:::::p     p:::::p i::::i 
d:::::d     d:::::d j::::j  aa::::::::::::a  k:::::::::::k     aa::::::::::::a        aa::::::::::::a p:::::p     p:::::p i::::i 
d:::::d     d:::::d j::::j a::::aaaa::::::a  k:::::::::::k    a::::aaaa::::::a       a::::aaaa::::::a p:::::p     p:::::p i::::i 
d:::::d     d:::::d j::::ja::::a    a:::::a  k::::::k:::::k  a::::a    a:::::a      a::::a    a:::::a p:::::p    p::::::p i::::i 
d::::::ddddd::::::ddj::::ja::::a    a:::::a k::::::k k:::::k a::::a    a:::::a      a::::a    a:::::a p:::::ppppp:::::::pi::::::i
 d:::::::::::::::::dj::::ja:::::aaaa::::::a k::::::k  k:::::ka:::::aaaa::::::a      a:::::aaaa::::::a p::::::::::::::::p i::::::i
  d:::::::::ddd::::dj::::j a::::::::::aa:::ak::::::k   k:::::ka::::::::::aa:::a      a::::::::::aa:::ap::::::::::::::pp  i::::::i
   ddddddddd   dddddj::::j  aaaaaaaaaa  aaaakkkkkkkk    kkkkkkkaaaaaaaaaa  aaaa       aaaaaaaaaa  aaaap::::::pppppppp    iiiiiiii
                    j::::j                                                                            p:::::p                    
          jjjj      j::::j                                                                            p:::::p                    
         j::::jj   j:::::j                                                                           p:::::::p                   
         j::::::jjj::::::j                                                                           p:::::::p                   
          jj::::::::::::j                                                                            p:::::::p                   
            jjj::::::jjj                                                                             ppppppppp                   
               jjjjjj                                                                                                            
";


    }
}
