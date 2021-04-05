# KodlamaİO C# Kampı Backend ReCapProject

# Mimari Yapı

# Core
Bu katman Cross Cutting Concern, Generic Repository, Jwt vb. yapıların AOP yöntemleriyle ve/veya tek satırlık kodlarla hazır olarak sunulduğu katmandır.

# Entities
Projenizin veri erişim katmanıdır. Bu katman veri tabanı ilişkilerinin yapıldığı, Contextlerin belirlendiği ve veri tabanı erişim teknolojilerinin kullanıldığı (EFCore, MongoDb vb.) katmandır.

# Business
Projenizin tüm iş kurallarının yazılacağı, entegrasyon mekanizmalarının yerleştirileceği katmandır. CQRS yaklaşımı sayesinde tüm kuralları esnek bir yapıda sunabilirsiniz. İster monolitik istenirse de microservis mimarilerine uygun olarak hizmet sunumu gerçekleştirilebilir.

# WebAPI
Projenizin önyüz çatılarıyla (Front-End Frameworks) iletişim kuracağı API yüzeyi katmanıdır. Güvenlik mekanizmasıyla birlikte gelir. Auth modülü metotları dışında tüm API yüzeyi için sisteme giriş yapmış bir kullanıcı bilgisi bekler.
