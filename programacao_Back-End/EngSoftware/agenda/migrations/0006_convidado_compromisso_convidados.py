# Generated by Django 4.2.2 on 2023-06-20 01:38

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('agenda', '0005_alter_local_options_compromisso_local'),
    ]

    operations = [
        migrations.CreateModel(
            name='Convidado',
            fields=[
                ('id', models.BigAutoField(auto_created=True, primary_key=True, serialize=False, verbose_name='ID')),
                ('nome', models.CharField(max_length=80)),
                ('email', models.EmailField(blank=True, max_length=254, null=True)),
            ],
        ),
        migrations.AddField(
            model_name='compromisso',
            name='convidados',
            field=models.ManyToManyField(to='agenda.convidado'),
        ),
    ]
