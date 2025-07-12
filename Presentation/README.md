# Balance.Presentation

طبقة الـ Presentation (Web API) لمنصة إدارة العقارات Balance.

## الهيكل

- **Controllers/**: جميع الـ API Controllers لكل كيان
- **Filters/**: فلاتر التحقق ومعالجة الأخطاء
- **Middleware/**: ميدل وير للتعدد اللغوي، JWT، الأخطاء
- **Extensions/**: توسيعات للخدمات، Swagger، Localization
- **Resources/**: ملفات الترجمة (ar, en)

## المميزات
- دعم التعدد اللغوي (Localization)
- توثيق Swagger
- معالجة الأخطاء بشكل موحد
- دعم JWT
- بنية قابلة للتوسعة

## المتطلبات
- .NET 8
- الربط مع الطبقات الأخرى (يتم لاحقاً) 

## 📖 Swagger API Documentation

- **Grouping:** جميع الـ Endpoints مجمعة حسب الـ Controller (Projects, Units, Users, Admin, Employee, Guest, Auth, FileUpload, InterestRequest, Favorites...)
- **Security:** دعم JWT Bearer في جميع Endpoints المحمية، مع إمكانية تجربة التوكن مباشرة من Swagger.
- **Examples:** كل Endpoint موثق مع أمثلة للمدخلات والمخرجات (input/output) وصلاحية الوصول (الدور المسموح).
- **Roles:** كل Endpoint يوضح الدور المسموح به (Admin, Employee, User, Guest) في التوثيق.
- **Endpoints إضافية:**
  - InterestRequest: إرسال طلب اهتمام (متاح للجميع)، عرض الطلبات (Admins فقط)
  - Favorites: إضافة/حذف/عرض المفضلات (User فقط)

> يمكنك تجربة جميع العمليات مباشرة من Swagger UI، مع رؤية التوثيق الكامل لكل دور وصلاحية. 