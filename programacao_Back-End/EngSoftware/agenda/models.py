from django.db import models
from django.dispatch import receiver


# Create your models here.
class Local(models.Model):
    nome = models.CharField(max_length=50)
    rua = models.CharField(max_length=255)
    numero = models.CharField(max_length=255)
    complemento = models.CharField(max_length=255)

    def __str__(self):
        return f'{self.nome} na rua {self.rua}'

    class Meta:
        verbose_name_plural = "Locais"


class Convidado(models.Model):
    # user = models.OneToOneField(User, on_delete=models.CASCADE)
    nome = models.CharField(max_length=80)
    email = models.EmailField(null=True, blank=True)

    def __str__(self):
        return f'{self.nome} - {self.email}'

# @receiver(post_save, sender=User)
# def criar_convidado(sender, instance, created, **kwargs):
#     if created:
#         Convidado.objects.create(user=instance)

# @receiver(post_save, sender=User)
# def salvar_convidado(sender, instance, **kwargs):
#     instance.convidado.save()


class Compromisso(models.Model):
    compromisso = models.CharField(max_length=255)
    date_inicio = models.DateTimeField(null=True)
    date_fim = models.DateTimeField(null=True)
    local = models.ForeignKey(Local, on_delete=models.CASCADE)
    convidados = models.ManyToManyField(Convidado)

    def __str__(self):
        return f'{self.compromisso} começa {self.date_inicio} até {self.date_fim}'
