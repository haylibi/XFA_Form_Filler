
from bs4 import BeautifulSoup
from pypdf import PdfReader, PdfWriter
import pandas as pd
import dicttoxml


reader = PdfReader("..\D394_KLRO_15984150_05.2023.pdf")
writer = PdfWriter()



# Copy PDF to new empty file
for page in reader.pages:
    fields = reader.get_fields()
    
    writer.add_page(page)
    

# Read form data
XFA = reader.xfa

# FIND DEFAULT ENCODER
encoding = XFA['xdp:xdp'].decode()
encoding = encoding[encoding.find('encoding='):]
encoding = encoding[encoding.find('"'):encoding.find('?')].replace('"', '')



soup = BeautifulSoup(XFA['datasets'], from_encoding=encoding)


# sub = soup.find('tip1').find('sub1')
# # Delete current data that exists
# for i, sub in enumerate(soup.find('tip1').findAll('sub1')):
#     if i==0: continue
#     sub.decompose()
    

# XFA['datasets'] = soup.prettify(encoding=encoding)



# writer.xfa = XFA



# from reportlab.pdfgen import canvas
# from reportlab.lib.pagesizes import letter

# def generate_pdf_with_xfa(output_path, XFA):
#     xfa_content = dicttoxml.dicttoxml(XFA, custom_root='xfa', attr_type=False).decode(encoding)
    
#     c = canvas.Canvas(output_path, pagesize=letter)
#     c.setFont("Helvetica", 12)
#     c.drawString(100, 700, "XFA Form Content:")
#     c.drawString(100, 680, xfa_content)
#     c.showPage()
#     c.save()

        
# # write "output" to PyPDF2-output.pdf
# generate_pdf_with_xfa("filled-out.pdf", XFA)
    
    

# # Assuming xfa_content is a dictionary
