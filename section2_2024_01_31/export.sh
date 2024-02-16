datestring=$(date +'%Y_%m_%d')
filename="section2_$datestring$1"
git archive section2 --format zip --output /Users/lynns/working/$filename.zip
mv /Users/lynns/working/$filename.zip /Users/lynns/OneDrive\ -\ BYU-Idaho/24Winter_cse210