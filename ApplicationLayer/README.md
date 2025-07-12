# Application Layer

هذه الطبقة تحتوي على منطق الأعمال (Business Logic) وتطبيق قواعد النظام، وتتعامل مع الكيانات (Entities) عبر الخدمات (Services/UseCases) وواجهاتها (Interfaces)، وتستخدم نماذج نقل البيانات (DTOs) والتحقق من صحة البيانات (Validation).

## مجلدات الطبقة:
- **Interfaces/**: واجهات الخدمات (Contracts) التي تحدد ما يجب أن تفعله كل خدمة.
- **Services/**: الخدمات (تطبيقات الواجهات) التي تحتوي على منطق الأعمال.
- **DTOs/**: نماذج نقل البيانات بين الطبقات (Data Transfer Objects).
- **Validation/**: التحقق من صحة البيانات (FluentValidation أو DataAnnotations أو غيرها).

> هذه الطبقة لا تتعامل مباشرة مع قاعدة البيانات أو أي مصدر بيانات خارجي، بل تعتمد على واجهات (Interfaces) يتم تنفيذها في طبقة البنية التحتية (Infrastructure/Persistence). 