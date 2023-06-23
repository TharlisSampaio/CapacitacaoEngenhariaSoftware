# Generated by Django 4.2.2 on 2023-06-20 01:08

from django.db import migrations, models
import django.db.models.deletion


class Migration(migrations.Migration):

    dependencies = [
        ('agenda', '0004_local'),
    ]

    operations = [
        migrations.AlterModelOptions(
            name='local',
            options={'verbose_name_plural': 'Locais'},
        ),
        migrations.AddField(
            model_name='compromisso',
            name='local',
            field=models.ForeignKey(default=1, on_delete=django.db.models.deletion.CASCADE, to='agenda.local'),
            preserve_default=False,
        ),
    ]
