# KodlamaİO C# Kampı Backend ReCapProject

<img src="https://camo.githubusercontent.com/dd433625a6e00049c26f08143705ff9e32d5da44f503f1be133664b11e37e34b/68747470733a2f2f696d672e736869656c64732e696f2f62616467652f432532332d3233393132303f7374796c653d666f722d7468652d6261646765266c6f676f3d632d7368617270266c6f676f436f6c6f723d7768697465" alt="C-Sharp" data-canonical-src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&amp;logo=c-sharp&amp;logoColor=white" style="max-width:100%;"> <img src="https://camo.githubusercontent.com/d2eedef86b5c7700ce36b271700d22a225ed80deb882f1bc627b0b1d3543dd3f/68747470733a2f2f696d672e736869656c64732e696f2f62616467652f4153502e4e45542d3543324439313f7374796c653d666f722d7468652d6261646765266c6f676f3d2e6e6574266c6f676f436f6c6f723d7768697465" alt="Asp-net" data-canonical-src="https://img.shields.io/badge/ASP.NET-5C2D91?style=for-the-badge&amp;logo=.net&amp;logoColor=white" style="max-width:100%;"><img src="https://camo.githubusercontent.com/660a4e0e53571f8f593a56df74573cb8f09777268a87305057363a9b38a3dd59/68747470733a2f2f696d672e736869656c64732e696f2f62616467652f4175746f6661632d3030343838303f7374796c653d666f722d7468652d6261646765266c6f676f3d6e75676574266c6f676f436f6c6f723d7768697465" alt="Autofac" data-canonical-src="https://img.shields.io/badge/Autofac-004880?style=for-the-badge&amp;logo=nuget&amp;logoColor=white" style="max-width:100%;">

# Mimari Yapı

# Core
Bu katman Cross Cutting Concern, Generic Repository, Jwt vb. yapıların AOP yöntemleriyle ve/veya tek satırlık kodlarla hazır olarak sunulduğu katmandır.

# Entities
Projenizin veri erişim katmanıdır. Bu katman veri tabanı ilişkilerinin yapıldığı, Contextlerin belirlendiği ve veri tabanı erişim teknolojilerinin kullanıldığı (EFCore, MongoDb vb.) katmandır.
# DataAccess
Projenizin veri erişim katmanıdır. Bu katman veri tabanı ilişkilerinin yapıldığı, Contextlerin belirlendiği ve veri tabanı erişim teknolojilerinin kullanıldığı (EFCore, MongoDb vb.) katmandır.

# Business
Projenizin tüm iş kurallarının yazılacağı, entegrasyon mekanizmalarının yerleştirileceği katmandır. CQRS yaklaşımı sayesinde tüm kuralları esnek bir yapıda sunabilirsiniz. İster monolitik istenirse de microservis mimarilerine uygun olarak hizmet sunumu gerçekleştirilebilir.

# WebAPI
Projenizin önyüz çatılarıyla (Front-End Frameworks) iletişim kuracağı API yüzeyi katmanıdır. Güvenlik mekanizmasıyla birlikte gelir. Auth modülü metotları dışında tüm API yüzeyi için sisteme giriş yapmış bir kullanıcı bilgisi bekler.

<img src="https://camo.githubusercontent.com/dd433625a6e00049c26f08143705ff9e32d5da44f503f1be133664b11e37e34b/68747470733a2f2f696d672e736869656c64732e696f2f62616467652f432532332d3233393132303f7374796c653d666f722d7468652d6261646765266c6f676f3d632d7368617270266c6f676f436f6c6f723d7768697465" alt="C-Sharp" data-canonical-src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&amp;logo=c-sharp&amp;logoColor=white" style="max-width:100%;">
