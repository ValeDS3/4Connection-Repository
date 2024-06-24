TEST =:!!:!:!:!:!::!:!
ewd
echo $nom
n=$(echo $nom | cut -c1 | tr '[:upper:]' '[:lower:]')
echo $n
a=$(echo $nom | cut -f2 -d" " | tr '[:upper:]' '[:lower:]')
echo $a
nc=$n$a
echo $nc
