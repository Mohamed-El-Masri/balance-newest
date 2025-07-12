# Infrastructure Layer

هذه الطبقة مسؤولة عن كل ما يتعلق بالبنية التحتية للنظام:
- إدارة البيانات (DbContext, Repositories, UnitOfWork)
- التكاملات الخارجية (Cloudinary, Email, Notifications, Localization)
- التحويل بين الكيانات وDTOs (Mapping)
- تسجيل الخدمات في الـ Dependency Injection

## المجلدات:
- **Data/**: كل ما يخص قاعدة البيانات (EF Core, Repositories, UnitOfWork)
- **Integrations/**: خدمات التكامل مع مزودات خارجية (Cloudinary, Email, ...)
- **Mapping/**: ملفات AutoMapper Profiles
- **DependencyInjection/**: تسجيل كل الخدمات في DI Container 