import fileinput
import xml.etree.ElementTree as ET
text = open("C:\\Users\\Reilly\\Documents\\GitHub\\github io\\Reillyhewitson.github.io\\news.xml")
text = ET.parse(text)
root = text.getroot()
print (root)

