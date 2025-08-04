FROM python:3.13.5-alpine3.22

# Define o diretório de trabalho dentro do container
WORKDIR /app

# Copia os arquivos da aplicação para o container
COPY app.py /app/
COPY requirements.txt /app/

# Instala as dependências da aplicação
RUN pip install --no-cache-dir -r requirements.txt

# Copia o restante do codigo da aplicação para o diretório de trabalho
COPY . /app/

# Expõe a porta padrão (ajuste conforme sua aplicação)
EXPOSE 8000

# Comando para rodar a aplicação usando uvicorn
# O host 0.0.0.0 permite que a aplicação seja acessível de fora do container
CMD ["uvicorn", "app:app", "--host", "0.0.0.0", "--port", "8000", "--reload"]
